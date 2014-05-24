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

namespace Xanatos.Editor
{
	public partial class XanatosEditor : Form
	{
		public Camera3D Camera;
		bool Loaded = false;
		bool Initialized = false;
		Stopwatch Timer;

		public XanatosEditor()
		{
			InitializeComponent();
			Refresh();
		}

		public string FileLocation = null;
		public BaseGame Game
		{
			get;
			set;
		}

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
			sfd.Filter = "Xanatos Game (.xan)|*.xan";
			if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
				FileLocation = sfd.FileName;
				Game.Save(FileLocation);
				
				Refresh();
			}
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Xanatos Game (.xan)|*.xan";
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
				DataEditor.Refresh();
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
			} else {
				if (FileLocation == null) {
					saveToolStripMenuItem.Enabled = false;
				} else {
					saveToolStripMenuItem.Enabled = true;
				}

				saveAsToolStripMenuItem.Enabled = true;
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

			Camera.Viewport = new Rectangle(0, 0, glControl.Width, glControl.Height);

			GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
			GL.MatrixMode(MatrixMode.Modelview);
			GL.LoadIdentity();

			double dt = Timer.Elapsed.TotalSeconds;
			Timer.Restart();
			Camera.Draw(new FrameEventArgs(dt));

			glControl.SwapBuffers();
		}

		private void Initialize()
		{
			Camera = new Camera3D();
			Camera.OnRender += OnRender;

			Camera.Position = new Vector3d(1, 0, 1);
			Camera.LookAt(0, 0, 0);

			Timer = new Stopwatch();
			Timer.Start();

			Initialized = true;
		}

		private void OnRender(FrameEventArgs e)
		{
			GL.Begin(PrimitiveType.Quads);
			{
				GL.Color3(Color.Red);
				GL.Vertex3(0, 0, 0);

				GL.Color3(Color.Red);
				GL.Vertex3(0, 1, 0);

				GL.Color3(Color.Red);
				GL.Vertex3(1, 1, 0);

				GL.Color3(Color.Red);
				GL.Vertex3(1, 0, 0);
			}
			GL.End();
		}
	}
}
