using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState.Overworld;

namespace Xanatos.Networking.Battlefield
{
	class AddPiece : Message
	{
		public AddPiece() { }

		int PlayerID;
		string EntityRef;
		int X;
		int Y;

		public AddPiece(int PlayerID, string Entity, Vector2i Location)
		{
			this.PlayerID = PlayerID;
			this.EntityRef = Entity;
			this.X = Location.X;
			this.Y = Location.Y;
		}

		protected override void ExecuteMessage()
		{
			GameInfo.Battlefield.Add(PlayerID, GameState.Overworld.Entity.Entities[EntityRef], new Vector2i(X, Y));
		}
	}
}
