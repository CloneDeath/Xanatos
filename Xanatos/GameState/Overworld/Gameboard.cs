using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using OpenTK;
using System.Drawing;

namespace Xanatos.GameState.Overworld
{
	public class Gameboard
	{
		List<Piece> Pieces = new List<Piece>();

		public int Width;
		public int Height;

		public void SetSize(int width, int height)
		{
			this.Width = width;
			this.Height = height;
		}

		public Gameboard()
		{
			this.SetSize(1, 2);
		}

		public void Add(int PlayerID, Entity entity, int X, int Y)
		{
			Pieces.Add(new Piece(PlayerID, entity, X, Y));
		}

		internal void Draw()
		{
			GraphicsManager.DrawQuad(new Vector3d(0, 0, 0), new Vector3d(Width, 0, 0), new Vector3d(Width, Height, 0), new Vector3d(0, Height, 0), Color.Green);

			for (int i = 0; i <= Width; i++) {
				GraphicsManager.DrawLine(new Vector3d(i, 0, 0.01), new Vector3d(i, Height, 0.01), Color.Black);
			}
			for (int i = 0; i <= Height; i++) {
				GraphicsManager.DrawLine(new Vector3d(0, i, 0.01), new Vector3d(Width, i, 0.01), Color.Black);
			}

			foreach (Piece piece in Pieces) {
				piece.Draw();
			}
		}
	}
}
