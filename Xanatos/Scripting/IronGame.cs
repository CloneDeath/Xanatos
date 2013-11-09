using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld.Entities;
using Xanatos.GameState.Overworld;
using GLImp;

namespace Xanatos.Scripting
{
	static class IronGame
	{
		private static Dictionary<string, Entity> Entities
		{
			get
			{
				return Entity.Entities;
			}
		}

		public static IronBuilding GetBuilding(string Name)
		{
			if (Entities.ContainsKey(Name)) {
				if (Entities[Name] is Building) {
					return new IronBuilding(Entities[Name] as Building);
				} else {
					throw new Exception("Tried to receive '" + Name + "' as a Building, when it is really a " + Entities[Name].GetType().Name + ".");
				}
			} else {
				Building ret = new Building(Name);
				Entities[Name] = ret;
				new Networking.Entity.AddBuilding(Name).Send();
				return new IronBuilding(ret);
			}
		}

		private static Dictionary<string, Texture> Textures {
			get {
				return TextureManager.Textures;
			}
		}
		public static IronTexture GetTexture(string name)
		{
			if (Textures.ContainsKey(name)) {
				return new IronTexture(Textures[name]);
			} else {
				Texture tex = new Texture(GraphicsManager.GetError(), name, 0, 0, false);
				Textures[name] = tex;
				new Networking.Texture.Add(name).Send();
				return new IronTexture(tex);
			}
		}

		public static IronGameboard Battlefield
		{
			get
			{
				return new IronGameboard();
			}
		}
	}
}
