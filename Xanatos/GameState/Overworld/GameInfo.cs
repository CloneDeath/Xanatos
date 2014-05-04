using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld;

namespace Xanatos
{
	static class GameInfo
	{
		public static int MyPlayerID;
		public static Dictionary<int, Player> Players = new Dictionary<int,Player>();
		public static Player Me
		{
			get
			{
				return Players[MyPlayerID];
			}
		}
		public static Gameboard Battlefield;

		static GameInfo()
		{
			Battlefield = new Gameboard();
		}
	}
}
