using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using System.IO;

namespace Xanatos.Scripting
{
	public class IronTexture
	{
		internal Texture Texture;

		public IronTexture(Texture texture)
		{
			this.Texture = texture;
		}

		public void Load(string Name)
		{
			Texture.Image = new System.Drawing.Bitmap(Path.Combine(ScriptManager.CurrentDirectory, Name));
			new Networking.Texture.Load(Texture).Send();
		}
	}
}
