﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xanatos.Data;
using System.Collections;

namespace Xanatos.Editor
{
	public partial class DataEditorForm : Form
	{
		public DataEditorForm()
		{
			InitializeComponent();

			Refresh();
		}

		public BaseGame Game
		{
			get;
			set;
		}

		public override void Refresh()
		{
			cbDataItemType.Items.Clear();
			if (Game == null) {
				cbDataItemType.Enabled = false;
			} else {
				cbDataItemType.Enabled = true;

				var cbValues = new[] {
					new { Name = "Units", Value = (IList)Game.Units },
					new { Name = "Resources", Value = (IList)Game.Resources },
				};
				cbDataItemType.DisplayMember = "Name";
				cbDataItemType.ValueMember = "Value";
				cbDataItemType.DataSource = cbValues;
				
			}

			base.Refresh();
		}

		private void cbDataItemType_SelectedIndexChanged(object sender, EventArgs e)
		{
			List<DataItem> temp = new List<DataItem>();
			uiDataItemsEditor.DataItems = (IList)cbDataItemType.SelectedValue;
			uiDataItemsEditor.DataType = cbDataItemType.SelectedValue.GetType().GetGenericArguments()[0];
			uiDataItemsEditor.Refresh();
		}
	}
}
