using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using OpenTK;

namespace Xanatos.GameState.Overworld.Entities
{
	class City : Entity
	{
		public City(int x, int y) : base(x, y)
		{
			
		}
		Texture CitySprite = new Texture(@"Data\City.png", false);
		public override void Draw()
		{
			GraphicsManager.DrawQuad(new Vector3d(X, Y + 0.5, 1), new Vector3d(X + 1, Y + 0.5, 1), new Vector3d(X + 1, Y + 0.5, 0), new Vector3d(X, Y + 0.5, 0), CitySprite);
		}
	}
}
