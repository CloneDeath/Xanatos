using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class ByteSerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Byte); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Byte)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadByte();
		}
	}
}
