using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Xanatos.Data;
using System.Collections;

namespace Xanatos.Editor
{
	public partial class DataItemsEditorControl : UserControl
	{
		public DataItemsEditorControl()
		{
			InitializeComponent();

			DataGridBindingSource = new BindingSource();
			dgvDataItems.DataSource = DataGridBindingSource;

			DataGridBindingSource.CurrentItemChanged += new EventHandler(DataGridBindingSource_DataItemChanged);
		}

		private BindingSource DataGridBindingSource;
		public IList DataItems
		{
			get;
			set;
		}

		public Type DataType
		{
			get;
			set;
		}

		public override void Refresh()
		{
			if (DataItems == null) {
				DataGridBindingSource.DataSource = null;
				dgvDataItems.Enabled = false;

				btnAddDataItem.Enabled = false;
				btnDeleteDataItem.Enabled = false;
			} else {
				DataGridBindingSource.DataSource = DataItems;
				dgvDataItems.Enabled = true;

				btnAddDataItem.Enabled = true;
				btnDeleteDataItem.Enabled = true;
			}

			base.Refresh();
		}

		private void btnAddDataItem_Click(object sender, EventArgs e)
		{
			DataGridBindingSource.Add(Activator.CreateInstance(DataType));
		}

		private void btnDeleteDataItem_Click(object sender, EventArgs e)
		{
			if (DataGridBindingSource.Current != null) {
				DataGridBindingSource.Remove(DataGridBindingSource.Current);
			}
		}

		void DataGridBindingSource_DataItemChanged(object sender, EventArgs e)
		{
			if (DataGridBindingSource.Current != null) {
				pgCurrentItem.Enabled = true;
			} else {
				pgCurrentItem.Enabled = false;
			}
			pgCurrentItem.SelectedObject = DataGridBindingSource.Current;
		}

		
	}
}
