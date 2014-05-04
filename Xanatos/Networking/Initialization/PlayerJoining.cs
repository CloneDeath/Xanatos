using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState;

namespace Xanatos.Networking.Initialization
{
	class PlayerJoining : Message
	{
		protected override void ExecuteMessage()
		{
			GameInfo.Players[0] = new Xanatos.Player(0);
			GameInfo.MyPlayerID = 0;
			new Player.Add(0).Send();

			GameInfo.Players[1] = new Xanatos.Player(1);
			new Player.Add(1).Send();


			new PlayerAssignment(1).Reply();
			Program.SwitchState(new Game());
		}
	}
}
