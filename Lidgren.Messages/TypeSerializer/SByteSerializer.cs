using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class SByteSerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(SByte); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((SByte)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadSByte();
		}
	}
}
