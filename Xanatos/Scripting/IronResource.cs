using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos.Scripting
{
	public class IronResource
	{
		internal GameState.Overworld.Resource Resource;

		internal IronResource(GameState.Overworld.Resource resource)
		{
			this.Resource = resource;
		}

		public IronTexture Image
		{
			get
			{
				return new IronTexture(Resource.ResourceIcon);
			}
			set
			{
				Resource.ResourceIcon = value.Texture;
				new Networking.Resource.SetResourceIcon(Resource).Send();
			}
		}
	}
}
