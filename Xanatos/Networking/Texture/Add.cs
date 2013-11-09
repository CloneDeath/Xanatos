using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState.Overworld;

namespace Xanatos.Networking.Texture
{
	class Add : Message
	{
		string TextureName;

		public Add() { }
		public Add(string TextureName)
		{
			this.TextureName = TextureName;
		}

		protected override void ExecuteMessage()
		{
			GLImp.Texture tex = new GLImp.Texture(GLImp.GraphicsManager.GetError(), TextureName, 0, 0, false);
			TextureManager.Textures[TextureName] = tex;
		}
	}
}
