using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos.GameState.Overworld
{
	class Piece
	{
		public int X;
		public int Y;
		public Entity Instance;
		public int PlayerID;

		public Piece(int playerid, Entity instance, int x, int y)
		{
			this.X = x;
			this.Y = y;
			this.Instance = instance;
			this.PlayerID = playerid;
		}

		public void Draw()
		{
			Instance.Draw(X, Y);
		}
	}
}
