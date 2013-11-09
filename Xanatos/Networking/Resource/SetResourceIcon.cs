using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState.Overworld;

namespace Xanatos.Networking.Resource
{
	class SetResourceIcon : Message
	{
		string ResourceName;
		string TextureName;

		public SetResourceIcon() { }
		public SetResourceIcon(GameState.Overworld.Resource res)
		{
			this.ResourceName = res.Name;
			this.TextureName = res.ResourceIcon.Name;
		}

		protected override void ExecuteMessage()
		{
			ResourceManager.Resources[ResourceName].ResourceIcon = TextureManager.Textures[TextureName];
		}
	}
}
