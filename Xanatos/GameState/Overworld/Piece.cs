using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos.GameState.Overworld
{
	class Piece
	{
		Vector2i Location;

		public Entity Instance;
		public int PlayerID;

		public Piece(int playerid, Entity instance, Vector2i location)
		{
			this.Location = location;
			this.Instance = instance;
			this.PlayerID = playerid;
		}

		public void Draw()
		{
			Instance.Draw(Location);
		}
	}
}
