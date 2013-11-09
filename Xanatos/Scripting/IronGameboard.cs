using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld;
using IronPython.Runtime;

namespace Xanatos.Scripting
{
	public class IronGameboard
	{
		private Gameboard Battlefield {
			get {
				return GameInfo.Battlefield;
			}
		}

		public void Add(int PlayerID, IronEntity EntityType, PythonTuple Location)
		{
			Vector2i loc = new Vector2i((int)Location[0], (int)Location[1]);
			Battlefield.Add(PlayerID, EntityType.Entity, loc);
			new Networking.Battlefield.AddPiece(PlayerID, EntityType.Entity.Name, loc).Send();
		}

		public void SetSize(int width, int height)
		{
			Battlefield.SetSize(width, height);
			new Networking.Battlefield.SetSize(width, height).Send();
		}
	}
}
