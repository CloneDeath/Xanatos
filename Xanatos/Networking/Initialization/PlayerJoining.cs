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
			new PlayerAssignment(1).Reply();
			Program.SwitchState(new Game());
		}
	}
}
