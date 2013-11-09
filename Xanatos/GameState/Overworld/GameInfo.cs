using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld;

namespace Xanatos
{
	static class GameInfo
	{
		public static Player Player;
		public static Gameboard Battlefield;

		static GameInfo()
		{
			Player = new Player();
			Battlefield = new Gameboard();
		}
	}
}
