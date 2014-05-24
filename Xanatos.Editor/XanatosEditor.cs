using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xanatos.Data;
using GLImp;
using System.Diagnostics;
using OpenTK.Graphics.OpenGL;
using OpenTK;
using Xanatos.Game;

namespace Xanatos.Editor
{
	public partial class XanatosEditor : Form
	{
		GameRenderer Renderer;
		bool Loaded = false;
		bool Initialized = false;
		Stopwatch Timer;
		System.Timers.Timer _repaint;

		public XanatosEditor()
		{
			InitializeComponent();
			Refresh();

			_repaint = new System.Timers.Timer(1000.0 / 60.0);
			_repaint.Elapsed += new System.Timers.ElapsedEventHandler(_repaint_Elapsed);
			_repaint.Start();			
		}

		void _repaint_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
		{
			glControl.Invalidate();
		}

		public string FileLocation = null;
		public BaseGame Game { get; set; }

		public DataEditorForm DataEditor;
		public EventEditorForm EventEditor;

		private void newToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewGameForm form = new NewGameForm();
			if (form.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				Game = form.Game;
				FileLocation = null;
				Refresh();
			}
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (FileLocation == null) throw new InvalidOperationException();

			Game.Save(FileLocation);
		}

		private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SaveFileDialog sfd = new SaveFileDialog();
			sfd.Filter = "Xanatos Game (*.xan)|*.xan";
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				FileLocation = sfd.FileName;
				Game.Save(FileLocation);
				
				Refresh();
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Xanatos Game (*.xan)|*.xan";
			if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				FileLocation = ofd.FileName;
				Game = BaseGame.Load(FileLocation);

				Refresh();
			}
		}

		private void dataEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (DataEditor == null || DataEditor.IsDisposed) {
				DataEditor = new DataEditorForm();
				DataEditor.Game = this.Game;
			}
			DataEditor.Show();
			DataEditor.Focus();
			DataEditor.Refresh();
		}

		private void eventEditorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (EventEditor == null || EventEditor.IsDisposed) {
				EventEditor = new EventEditorForm();
			}
			EventEditor.Show();
			EventEditor.Focus();
		}

		public override void Refresh()
		{
			if (Game == null) {
				saveAsToolStripMenuItem.Enabled = false;
				saveToolStripMenuItem.Enabled = false;

				pgMapInfo.SelectedObject = null;

				if (Renderer != null) {
					Renderer.Map = null;
				}
			} else {
				if (FileLocation == null) {
					saveToolStripMenuItem.Enabled = false;
				} else {
					saveToolStripMenuItem.Enabled = true;
				}
				saveAsToolStripMenuItem.Enabled = true;

				pgMapInfo.SelectedObject = Game.MapInformation;

				if (Renderer != null) {
					Renderer.Map = Game.MapInformation;
				}
			}

			if (EventEditor != null) {
				DataEditor.Game = this.Game;
				EventEditor.Refresh();
			}
			if (DataEditor != null) {
				DataEditor.Refresh();
			}

			base.Refresh();
		}

		private void XanatosEditor_Load(object sender, EventArgs e)
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
