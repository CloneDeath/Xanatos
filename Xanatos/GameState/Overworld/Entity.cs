using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using OpenTK;
using System.IO;

namespace Xanatos.GameState.Overworld
{
	public abstract class Entity
	{
		public static Dictionary<string, Entity> Entities = new Dictionary<string, Entity>();

		public Entity(string Name)
		{
			this.Name = Name;
		}

		public Texture WorldTexture;
		public string Name;
		public virtual void Draw(Vector2i Location)
		{
			GraphicsManager.DrawQuad(
				new Vector3d(Location.X, Location.Y + 0.5, 1),
				new Vector3d(Location.X + 1, Location.Y + 0.5, 1),
				new Vector3d(Location.X + 1, Location.Y + 0.5, 0),
				new Vector3d(Location.X, Location.Y + 0.5, 0),
			WorldTexture);
		}
	}
}
