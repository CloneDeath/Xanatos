using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;

namespace Xanatos.GameState.Overworld
{
	class Resource
	{
		public Texture ResourceIcon;
		public string Name;

		public Resource(string name)
		{
			this.Name = name;
		}
	}
}
