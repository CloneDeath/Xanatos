using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState.Overworld;

namespace Xanatos.Networking.Entity
{
	class SetWorldTexture : Message
	{
		string EntityName;
		string TextureName;

		public SetWorldTexture() { }
		public SetWorldTexture(GameState.Overworld.Entity ent)
		{
			this.EntityName = ent.Name;
			this.TextureName = ent.WorldTexture.Name;
		}

		protected override void ExecuteMessage()
		{
			GameState.Overworld.Entity.Entities[EntityName].WorldTexture = TextureManager.Textures[TextureName];
		}
	}
}
