using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;
using GLImp;
using OpenTK;
using System.Drawing;
using OpenTK.Input;
using Xanatos.GameState.Overworld;
using Xanatos.GameState.Overworld.Entities;

namespace Xanatos.GameState
{
	class Game : IGameState
	{
		Camera3D Gameview;

		public void Initialize()
		{
			WindowControl rightpanel = new WindowControl(MainCanvas.Instance);
			rightpanel.Dock = Gwen.Pos.Right;
			rightpanel.Width = (GraphicsManager.WindowWidth / 2) - 20;
			rightpanel.IsClosable = false;
			rightpanel.DisableResizing();

			Base dummy = new Base(MainCanvas.Instance);
			dummy.Dock = Gwen.Pos.Fill;

			WindowControl bottompanel = new WindowControl(dummy);
			bottompanel.Dock = Gwen.Pos.Bottom;
			bottompanel.Height = (GraphicsManager.WindowHeight / 2) - 20;
			bottompanel.IsClosable = false;
			bottompanel.DisableResizing();

			Gameview = new Camera3D();
			Gameview.Layer = 1;
			Gameview.FieldOfView = 60;
			Gameview.EnableViewport(10, 10, GraphicsManager.WindowWidth / 2, GraphicsManager.WindowHeight / 2);
			Gameview.OnRender += GameRender;

			Console.WriteLine(GameInfo.Player.ID);

			if (GameInfo.Player.IsServer) {
				ScriptManager.Initialize();
			}
		}

		public void Uninitialize()
		{
			Gameview.Disable();
		}

		public void GameRender()
		{
			/* Terrain */
			GameInfo.Battlefield.Draw();

			/* Lookat */
			Vector2d mousepos;
			if (MouseMonitor.GetMousePosition(Gameview, out mousepos)) {
				GraphicsManager.DrawLine(new Vector3d(mousepos.X, mousepos.Y, 0), new Vector3d(mousepos.X, mousepos.Y, 1), Color.White);
			}

			Gameview.Position = new Vector3d(2.5, -0.5, 4);
			Gameview.LookAt(2.5, 2.5, 0);
		}

		public void Draw2D(float dt)
		{
			//GameRender Background
			GraphicsManager.DrawRectangle(0, 0, (GraphicsManager.WindowWidth / 2) + 20, (GraphicsManager.WindowHeight / 2) + 20, Color.Black);
		}

		public void Update(float dt)
		{
			
		}
	}
}
