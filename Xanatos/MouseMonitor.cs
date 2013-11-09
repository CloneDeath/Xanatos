using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenTK;
using GLImp;
using System.Drawing;

namespace Xanatos
{
	static class MouseMonitor
	{
		public static bool GetMousePosition(Camera3D camera, out Vector2d position)
		{
			Vector2d ViewArea = new Vector2d(camera.Viewport.Width, camera.Viewport.Height);
			Vector2d MouseAt = MouseManager.GetMousePosition() - new Vector2d(camera.Viewport.X, camera.Viewport.Y);
			if (MouseAt.X < 0 || MouseAt.Y < 0 || MouseAt.X > camera.Viewport.Width || MouseAt.Y > camera.Viewport.Height) {
				position = new Vector2d();
				return false;
			}

			Vector3d ray = camera.ScreenPointToRay(MouseAt);

			Vector3d pos;
			AABBCollision.CheckLineBox(new Vector3d(0, 0, -1), new Vector3d(5, 7, 0), camera.Position, (ray * 30) + camera.Position, out pos);
			position = pos.Xy;
			return true;
		}
	}
}
