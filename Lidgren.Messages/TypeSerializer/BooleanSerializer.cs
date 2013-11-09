using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class BooleanSerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Boolean); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Boolean)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadBoolean();
		}
	}
}
