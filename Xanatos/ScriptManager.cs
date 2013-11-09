using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;
using System.IO;
using System.Drawing;
using System.Reflection;
using Xanatos.Scripting;

namespace Xanatos {
	class ScriptManager {
		internal static void Initialize() {
			InitializeScripts();
		}


		public delegate object AllFunctions(params object[] input);
		private static void CreateModuleFromClass(ScriptEngine engine, Type t, string ModuleName)
		{
			var Module = engine.CreateModule(ModuleName);
			foreach (MemberInfo m in t.GetMembers(BindingFlags.Public | BindingFlags.Static)){
				
				if (m.MemberType == MemberTypes.Method){
					MethodInfo method = (MethodInfo)m;
					Module.SetVariable(m.Name, (AllFunctions)delegate(object[] input){ return method.Invoke(null, input);});
					continue;
				}

				if (m.MemberType == MemberTypes.Property){
					MethodInfo method = ((PropertyInfo)m).GetGetMethod();
					Module.SetVariable(m.Name, method.Invoke(null, null));
					continue;
				}

				if (m.MemberType == MemberTypes.Field) {
					FieldInfo field = (FieldInfo)m;
					Module.SetVariable(field.Name, field.GetValue(null));
				}

				Console.WriteLine("Not supported: " + m.Name + " for module: " + ModuleName);
			}
		}

		private static void CreateModuleFromClass(ScriptEngine engine, object t, string ModuleName)
		{
			var Module = engine.CreateModule(ModuleName);
			foreach (MemberInfo m in t.GetType().GetMembers(BindingFlags.Public | BindingFlags.Instance)) {

				if (m.MemberType == MemberTypes.Method) {
					MethodInfo method = (MethodInfo)m;
					Module.SetVariable(m.Name, (AllFunctions)delegate(object[] input) { return method.Invoke(t, input); });
					continue;
				}

				if (m.MemberType == MemberTypes.Property) {
					MethodInfo method = ((PropertyInfo)m).GetGetMethod();
					Module.SetVariable(m.Name, method.Invoke(t, null));
					continue;
				}

				Console.WriteLine("Not supported: " + m.Name + " for module: " + ModuleName);
			}
		}

		private static void CreateModuleFromEnum(ScriptEngine engine, Type t, string ModuleName)
		{
			var Module = engine.CreateModule(ModuleName);
			foreach (MemberInfo m in t.GetMembers(BindingFlags.Public | BindingFlags.Static)) {
				if (m.MemberType == MemberTypes.Field) {
					Module.SetVariable(m.Name, ((FieldInfo)m).GetValue(null));
					continue;
				}

				Console.WriteLine("Not supported: " + m.Name + " for module: " + ModuleName);
			}
		}

		public static ScriptEngine Engine;

		private static void InitializeScripts() {
			Engine = Python.CreateEngine();

			CreateModuleFromClass(Engine, typeof(IronGame), "Xanatos");
			CreateModuleFromClass(Engine, typeof(Color), "Color");
			CreateModuleFromClass(Engine, new Random(), "Random");
			RecursivelyRunScriptsIn(@"Data\");			
		}

		public static string CurrentDirectory;

		private static void RecursivelyRunScriptsIn(string Location) {
			CurrentDirectory = Location;
			foreach (string file in Directory.GetFiles(Location)) {
				if (Path.GetExtension(file) == ".py") {
					LoadScript(file);
				}
			}

			foreach (string Dir in Directory.GetDirectories(Location)) {
				RecursivelyRunScriptsIn(Dir);
			}
		}

		private static void LoadScript(string file)
		{
			ScriptScope scope = Engine.Runtime.CreateScope();
			ScriptScope script = Engine.ExecuteFile(file, scope);
		}
	}
}
