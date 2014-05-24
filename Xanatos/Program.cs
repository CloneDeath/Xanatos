using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GLImp;
using System.Drawing;
using Gwen.Control;
using System.Diagnostics;
using Lidgren.Network;
using Lidgren.Messages;
using OpenTK;

namespace Xanatos
{
	public class Program
	{
		static Stopwatch DrawTime = new Stopwatch();
		static Stopwatch UpdateTime = new Stopwatch();
		static IGameState CurrentState = null;

		public static NetPeer Connection;

		static Camera2D Camera2D;

		public static void Main(string[] args)
		{
			//GraphicsManager.SetWindowState(OpenTK.WindowState.Maximized);
			GraphicsManager.SetTitle("Xanatos");
			GraphicsManager.SetBackground(Color.Black);

			GraphicsManager.Update += GraphicsManager_Update;

			//Draw2D
			Camera2D = new Camera2D();
			Camera2D.OnRender += Draw2D;

			Initialize();
			GraphicsManager.Start();
		}

		private static void Initialize()
		{
			SwitchState(new GameState.MainMenu());
			DrawTime.Start();
			UpdateTime.Start();
		}

		internal static void SwitchState(IGameState newstate)
		{
			if (CurrentState != null) {
				CurrentState.Uninitialize();
			}
			newstate.Initialize();
			CurrentState = newstate;
		}

		static void GraphicsManager_Update(FrameEventArgs e)
		{
			float dt = UpdateTime.ElapsedMilliseconds / 1000f;
			UpdateTime.Restart();

			Message.Update();
			CurrentState.Update(dt);
		}


		static void Draw2D(FrameEventArgs e)
		{
			float dt = DrawTime.ElapsedMilliseconds / 1000f;
			DrawTime.Restart();

			CurrentState.Draw2D(dt);
		}
	}
}
