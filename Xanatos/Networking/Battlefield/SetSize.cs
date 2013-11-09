using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;

namespace Xanatos.Networking.Battlefield
{
	class SetSize : Message
	{
		int Width;
		int Height;

		public SetSize() { }
		public SetSize(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		protected override void ExecuteMessage()
		{
			GameInfo.Battlefield.SetSize(Width, Height);
		}
	}
}
