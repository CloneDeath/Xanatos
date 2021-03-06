﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;
using System.Reflection;

namespace Lidgren.Messages
{
	public abstract partial class Message
	{
		public static void Handle(NetIncomingMessage Message)
		{
			if (Message.MessageType == NetIncomingMessageType.Data) {
				List<Type> types = FindDerivedTypes();
				Type Match = GetMatch(types, Message.ReadString());
				Parse(Match, Message);
			}
		}

		private static void Parse(Type Match, NetIncomingMessage Message)
		{
			if (Match.GetConstructor(new Type[0]) == null) {
				throw new Exception("Message '" + Match.Name + "' Does not have an empty constructor!");
			}
			Message msg = (Message)Match.GetConstructor(new Type[0]).Invoke(new object[0]);
			msg.Receive(Message);
		}

		private static Type GetMatch(List<Type> types, string name)
		{
			foreach (Type t in types) {
				if (t.FullName == name) {
					return t;
				}
			}
			throw new Exception("Unknown message type: '" + name + "'");
		}

		private static List<Type> FindDerivedTypes()
		{
			List<Type> ret = new List<Type>();
			Type baseType = typeof(Message);
			foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies()) {
				ret.AddRange(asm.GetTypes().Where(t => t != baseType && baseType.IsAssignableFrom(t)));
			}
			return ret;
		}
	}
}
