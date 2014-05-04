using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Xanatos.Networking.Player
{
	class Add : Message
	{
		int ID;

		public Add() { }
		public Add(int ID)
		{
			this.ID = ID;
		}

		protected override void ExecuteMessage()
		{
			GameInfo.Players[ID] = new Xanatos.Player(ID);
		}
	}
}
