using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class StringSerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(String); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((String)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadString();
		}
	}
}
