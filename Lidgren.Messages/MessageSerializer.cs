using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using Lidgren.Messages.TypeSerializer;
using Lidgren.Network;

namespace Lidgren.Messages
{
	static class MessageSerializer
	{
		public static Dictionary<Type, ISerializer> Serializers = new Dictionary<Type, ISerializer>();
		static MessageSerializer()
		{
			AddSerializer(new BooleanSerializer());
			AddSerializer(new ByteArraySerializer());
			AddSerializer(new ByteSerializer());
			AddSerializer(new SByteSerializer());
			AddSerializer(new SingleSerializer());
			AddSerializer(new DoubleSerializer());
			AddSerializer(new StringSerializer());
			AddSerializer(new Int16Serializer());
			AddSerializer(new Int32Serializer());
			AddSerializer(new Int64Serializer());
			AddSerializer(new UInt16Serializer());
			AddSerializer(new UInt32Serializer());
			AddSerializer(new UInt64Serializer());
			AddSerializer(new IPEndPointSerializer());
		}

		public static void AddSerializer(ISerializer serializer){
			Serializers.Add(serializer.Target, serializer);
		}

		public static void Write(Object obj, BindingFlags flags, NetOutgoingMessage message)
		{
			if (obj == null)
				return;
			Type tp = obj.GetType();

			FieldInfo[] fields = tp.GetFields(flags);
			SortMembersList(fields);

			foreach (FieldInfo fi in fields) {
				object value = fi.GetValue(obj);

				// find the appropriate Write method
				ISerializer serializer = GetSerializer(fi.FieldType);
				if (serializer != null){
					serializer.Write(message, value);
				} else {
					throw new Exception("Failed to find write method for type " + fi.FieldType);
				}
			}
		}

		

		public static void Read(Object obj, BindingFlags flags, NetIncomingMessage message)
		{
			if (obj == null)
				return;
			Type tp = obj.GetType();

			FieldInfo[] fields = tp.GetFields(flags);
			SortMembersList(fields);

			foreach (FieldInfo fi in fields) {
				object value;

				// find read method
				ISerializer serializer = GetSerializer(fi.FieldType);
				if (serializer != null) {
					// read value
					value = serializer.Read(message);

					// set the value
					fi.SetValue(obj, value);
				} else {
					throw new Exception("Failed to find read method for type " + fi.FieldType);
				}
			}
		}

		private static ISerializer GetSerializer(Type type)
		{
			if (Serializers.ContainsKey(type)) {
				return Serializers[type];
			}

			foreach (ISerializer s in Serializers.Values) {
				if (s.Target.IsAssignableFrom(type)) {
					return s;
				}
			}
			return null;
		}

		private static void SortMembersList(FieldInfo[] fields)
		{
			Array.Sort(fields, FieldComparer);
		}

		private static int FieldComparer(FieldInfo a, FieldInfo b){
			return String.Compare(a.Name, b.Name);
		}
	}
}
