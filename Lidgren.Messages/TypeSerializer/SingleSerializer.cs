using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lidgren.Messages.TypeSerializer
{
	class SingleSerializer : ISerializer
	{
		public Type Target
		{
			get { return typeof(Single); }
		}

		public void Write(Network.NetOutgoingMessage nom, object Value)
		{
			nom.Write((Single)Value);
		}

		public object Read(Network.NetIncomingMessage nim)
		{
			return nim.ReadSingle();
		}
	}
}
