using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class ByteArraySerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Byte[]); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			byte[] val = Value as Byte[];
			nom.Write((Int32)val.Length);
			nom.Write((Byte[])val);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			int length = nim.ReadInt32();
			return nim.ReadBytes(length);
		}
	}
}
