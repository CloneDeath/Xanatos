using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class Int16Serializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Int16); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Int16)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return (Int16)nim.ReadInt16();
		}
	}
}
