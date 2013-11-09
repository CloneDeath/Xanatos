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

		public string Image
		{
			get
			{
				return WorldTexture.Location;
			}
			set
			{
				WorldTexture = new Texture(Path.Combine(ScriptManager.CurrentDirectory, value), false);
			}
		}

		Texture WorldTexture;
		public virtual void Draw(int X, int Y)
		{
			GraphicsManager.DrawQuad(
				new Vector3d(X, Y + 0.5, 1), 
				new Vector3d(X + 1, Y + 0.5, 1), 
				new Vector3d(X + 1, Y + 0.5, 0), 
				new Vector3d(X, Y + 0.5, 0),
			WorldTexture);
		}
	}
}
