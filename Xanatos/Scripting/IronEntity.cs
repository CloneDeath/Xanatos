using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld;

namespace Xanatos.Scripting
{
	public class IronEntity
	{
		internal Entity Entity;

		public IronEntity(Entity ent)
		{
			this.Entity = ent;
		}

		public IronTexture Image
		{
			get
			{
				return new IronTexture(Entity.WorldTexture);
			}
			set
			{
				Entity.WorldTexture = value.Texture;
				new Networking.Entity.SetWorldTexture(Entity).Send();
			}
		}
	}
}
