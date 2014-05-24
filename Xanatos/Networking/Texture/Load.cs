using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using System.Drawing;
using Xanatos.GameState.Overworld;

namespace Xanatos.Networking.Texture
{
	class Load : Message
	{
		//string Texturename;
		byte[] Data;

		public Load() { }
		public Load(GLImp.Texture tex)
		{
			//this.Texturename = tex.Name;
			this.Data = GetBytes(tex);
		}

		internal byte[] GetBytes(GLImp.Texture texture)
		{
			ImageConverter converter = new ImageConverter();
			return (byte[])converter.ConvertTo(texture.Image, typeof(byte[]));
		}

		static internal Bitmap GetBitmap(byte[] array)
		{
			ImageConverter ic = new ImageConverter();
			System.Drawing.Image pic = (System.Drawing.Image)ic.ConvertFrom(array);
			return new Bitmap(pic);
		}

		protected override void ExecuteMessage()
		{
			//TextureManager.Textures[Texturename].Image = GetBitmap(Data);
		}
	}
}
