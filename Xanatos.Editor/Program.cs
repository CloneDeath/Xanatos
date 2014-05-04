using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Xanatos.Data;
using System.ComponentModel;

namespace Xanatos.Editor
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			InjectAttributes();
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new XanatosEditor());
		}

		private static void InjectAttributes()
		{
			TypeDescriptor.AddAttributes(
				typeof(VariableValue),
				new EditorAttribute(typeof(VariableSelectionEditor), typeof(System.Drawing.Design.UITypeEditor)));
			//typeof(Variable).GetMember("Value")[0].cu;
		}
	}
}
