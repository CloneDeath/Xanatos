using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Design;
using System.ComponentModel;
using System.Windows.Forms;
using Xanatos.Data;

namespace Xanatos.Editor
{
	class VariableSelectionEditor : UITypeEditor
	{
		public override UITypeEditorEditStyle GetEditStyle(System.ComponentModel.ITypeDescriptorContext context)
		{
			return UITypeEditorEditStyle.Modal;
		}

		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{
			if (value is VariableValue) {
				VariableEditorForm vef = new VariableEditorForm();
				vef.Value = value as VariableValue;
				if (vef.ShowDialog() == DialogResult.OK) {
					return vef.Value;
				} else {
					return value;
				}
			} else {
				return value;
			}
		}
	}
}
