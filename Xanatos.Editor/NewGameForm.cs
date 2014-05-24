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
	public partial class NewGameForm : Form
	{
		public NewGameForm()
		{
			InitializeComponent();

			Game = new BaseGame();
		}

		public BaseGame Game
		{
			get;
			set;
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			Game.MapInformation.Name = tbName.Text;

			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}
	}
}
