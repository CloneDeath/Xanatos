using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.Data;
using GLImp;
using OpenTK;
using System.Drawing;
using OpenTK.Graphics.OpenGL;

namespace Xanatos.Game
{
	public class GameRenderer
	{
		public MapInfo Map;
		public Camera3D Camera { get; private set; }

		public GameRenderer()
		{
			Camera = new Camera3D();
			Camera.OnRender += OnRender;
			Camera.CameraUp = Vector3d.UnitZ;
		}

		private void OnRender(FrameEventArgs e)
		{
			if (Map == null) {
				GL.ClearColor(Color.Red);
				return;
			} else {
				GL.ClearColor(Color.Black);
			}

			/* Draw Gridlines */
			for (int i = 0; i <= Map.Size.Width; i++) {
				GraphicsManager.DrawLine(new Vector3d(i, 0, 0.01), new Vector3d(i, Map.Size.Height, 0.01), Color.White);
			}
			for (int i = 0; i <= Map.Size.Height; i++) {
				GraphicsManager.DrawLine(new Vector3d(0, i, 0.01), new Vector3d(Map.Size.Width, i, 0.01), Color.White);
			}
		}
	}
}
