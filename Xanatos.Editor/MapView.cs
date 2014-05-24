using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xanatos.Game;
using System.Diagnostics;
using Xanatos.Data;
using OpenTK.Graphics.OpenGL;
using OpenTK;

namespace Xanatos.Editor
{
	public partial class MapView : UserControl
	{
		public BaseGame Game { get; set; }

		GameRenderer Renderer;
		bool Loaded = false;
		bool Initialized = false;
		Stopwatch Timer;
		System.Timers.Timer _repaint;

		public MapView()
		{
			InitializeComponent();

			_repaint = new System.Timers.Timer(1000.0 / 60.0);
			_repaint.Elapsed += new System.Timers.ElapsedEventHandler(_repaint_Elapsed);
			_repaint.Start();	
		}

		void _repaint_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			glControl.Invalidate();
		}

		public override void Refresh()
		{
			if (Game == null) {
				if (Renderer != null) {
					Renderer.Map = null;
				}
			} else {
				if (Renderer != null) {
					Renderer.Map = Game.MapInformation;
				}
			}
			base.Refresh();
		}

		private void MapView_Load(object sender, EventArgs e)
		{
			Loaded = true;
		}

		private void glControl_Paint(object sender, PaintEventArgs e)
		{
			if (!Loaded) return;
			if (!Initialized) Initialize();

			glControl.MakeCurrent();

			Renderer.Camera.Viewport = new Rectangle(0, 0, glControl.Width, glControl.Height);

			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadIdentity();

			double dt = Timer.Elapsed.TotalSeconds;
			Timer.Restart();
			Renderer.Camera.Draw(new FrameEventArgs(dt));

			glControl.SwapBuffers();
		}

		private void Initialize()
		{
			Renderer = new GameRenderer();

			Renderer.Camera.Position = new Vector3d(0, -5, 5);
			Renderer.Camera.LookAt(0, 0, 0);

			Timer = new Stopwatch();
			Timer.Start();

			Initialized = true;
		}
	}
}
