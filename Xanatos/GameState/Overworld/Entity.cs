using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos.GameState.Overworld
{
	abstract class Entity
	{
		public int X;
		public int Y;

		public Entity(int x, int y)
		{
			this.X = x;
			this.Y = y;
		}

		public abstract void Draw();
	}
}
