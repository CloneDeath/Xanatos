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
	public partial class VariableEditorForm : Form
	{
		public VariableEditorForm()
		{
			InitializeComponent();

			Refresh();
		}

		public VariableValue Value { get; set; }

		private void btnOK_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		public override void Refresh()
		{
			if (Value == null || Value.Value == null) {
				Value = new VariableValue();
				Value.Value = "";
			}

			if (Value.Value is String || Value.Value is Int32 || Value.Value is Double) {
				tpPrimitive.Select();

				if (Value.Value is String) {
					rbString.Select();
					tbString.Text = (string)Value.Value;
				}

				if (Value.Value is Int32) {
					rbInteger.Select();
					nudInteger.Value = (Int32)Value.Value;
				}

				if (Value.Value is Double) {
					rbDouble.Select();
					nudDouble.Value = (Decimal)((Double)Value.Value);
				}
			}

			base.Refresh();
		}

		private void rbString_CheckedChanged(object sender, EventArgs e)
		{
			ClearPrimitiveData();
			tbString.Enabled = true;
		}

		private void rbInteger_CheckedChanged(object sender, EventArgs e)
		{
			ClearPrimitiveData();
			nudInteger.Enabled = true;
		}

		private void rbDouble_CheckedChanged(object sender, EventArgs e)
		{
			ClearPrimitiveData();
			nudDouble.Enabled = true;
		}

		private void ClearPrimitiveData()
		{
			tbString.Enabled = false;
			tbString.Text = "";
			nudInteger.Enabled = false;
			nudInteger.Value = 0;
			nudDouble.Enabled = false;
			nudDouble.Value = 0;
		}

		private void tbString_TextChanged(object sender, EventArgs e)
		{
			if (!rbString.Checked) return;

			Value.Value = tbString.Text;
		}

		private void nudInteger_ValueChanged(object sender, EventArgs e)
		{
			if (!rbInteger.Checked) return;

			Value.Value = (Int32)nudInteger.Value;
		}

		private void nudDouble_ValueChanged(object sender, EventArgs e)
		{
			if (!rbDouble.Checked) return;

			Value.Value = (Double)nudDouble.Value;
		}

		
	}
}
