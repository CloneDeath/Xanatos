using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class DoubleSerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Double); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Double)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadDouble();
		}
	}
}
