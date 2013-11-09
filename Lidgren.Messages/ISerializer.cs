using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;

namespace Lidgren.Messages
{
	interface ISerializer
	{
		Type Target
		{
			get;
		}
		void Write(NetOutgoingMessage nom, object Value);
		object Read(NetIncomingMessage nim);
	}
}
