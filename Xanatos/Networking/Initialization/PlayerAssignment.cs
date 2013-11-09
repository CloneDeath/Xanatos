using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState;

namespace Xanatos.Networking.Initialization
{
	class PlayerAssignment : Message
	{
		public int PlayerID;

		public PlayerAssignment() { }

		public PlayerAssignment(int playerid)
		{
			this.PlayerID = playerid;
		}

		protected override void ExecuteMessage()
		{
			GameInfo.Player.ID = PlayerID;
			Program.SwitchState(new Game());
		}
	}
}
