namespace Xanatos.Editor
{
	partial class DataEditorForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.cbDataItemType = new System.Windows.Forms.ComboBox();
			this.uiDataItemsEditor = new Xanatos.Editor.DataItemsEditorControl();
			this.SuspendLayout();
			// 
			// cbDataItemType
			// 
			this.cbDataItemType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbDataItemType.FormattingEnabled = true;
			this.cbDataItemType.Location = new System.Drawing.Point(12, 12);
			this.cbDataItemType.Name = "cbDataItemType";
			this.cbDataItemType.Size = new System.Drawing.Size(243, 21);
			this.cbDataItemType.TabIndex = 0;
			this.cbDataItemType.SelectedIndexChanged += new System.EventHandler(this.cbDataItemType_SelectedIndexChanged);
			// 
			// uiDataItemsEditor
			// 
			this.uiDataItemsEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.uiDataItemsEditor.DataItems = null;
			this.uiDataItemsEditor.DataType = null;
			this.uiDataItemsEditor.Location = new System.Drawing.Point(12, 39);
			this.uiDataItemsEditor.Name = "uiDataItemsEditor";
			this.uiDataItemsEditor.Size = new System.Drawing.Size(780, 482);
			this.uiDataItemsEditor.TabIndex = 1;
			// 
			// DataEditorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(804, 533);
			this.Controls.Add(this.uiDataItemsEditor);
			this.Controls.Add(this.cbDataItemType);
			this.Name = "DataEditorForm";
			this.Text = "DataEditorForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cbDataItemType;
		private DataItemsEditorControl uiDataItemsEditor;

	}
}