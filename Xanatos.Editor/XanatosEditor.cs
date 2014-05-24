using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xanatos.Data;

namespace Xanatos.Editor
{
	public partial class XanatosEditor : Form
	{
		public XanatosEditor()
		{
			InitializeComponent();
			Refresh();
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

			} else {
				if (FileLocation == null) {
					saveToolStripMenuItem.Enabled = false;
				} else {
					saveToolStripMenuItem.Enabled = true;
				}
				saveAsToolStripMenuItem.Enabled = true;

				pgMapInfo.SelectedObject = Game.MapInformation;
			}

			uiMapView.Game = this.Game;
			uiMapView.Refresh();

			if (EventEditor != null) {
				DataEditor.Game = this.Game;
				EventEditor.Refresh();
			}

			if (DataEditor != null) {
				DataEditor.Refresh();
			}

			base.Refresh();
		}
	}
}
