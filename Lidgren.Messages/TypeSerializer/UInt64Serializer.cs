using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class UInt64Serializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(UInt64); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((UInt64)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return (UInt64)nim.ReadUInt64();
		}
	}
}
