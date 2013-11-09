using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class Int32Serializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Int32); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Int32)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return (Int32)nim.ReadInt32();
		}
	}
}
