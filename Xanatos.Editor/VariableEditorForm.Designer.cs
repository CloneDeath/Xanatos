namespace Xanatos.Editor
{
	partial class VariableEditorForm
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
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpPrimitive = new System.Windows.Forms.TabPage();
			this.rbString = new System.Windows.Forms.RadioButton();
			this.rbInteger = new System.Windows.Forms.RadioButton();
			this.rbDouble = new System.Windows.Forms.RadioButton();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabControl1.SuspendLayout();
			this.tpPrimitive.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnCancel
			// 
			this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(455, 316);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// btnOK
			// 
			this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnOK.Location = new System.Drawing.Point(374, 316);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 1;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tpPrimitive);
			this.tabControl1.Location = new System.Drawing.Point(13, 13);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(517, 297);
			this.tabControl1.TabIndex = 2;
			// 
			// tpPrimitive
			// 
			this.tpPrimitive.Controls.Add(this.textBox1);
			this.tpPrimitive.Controls.Add(this.rbDouble);
			this.tpPrimitive.Controls.Add(this.rbInteger);
			this.tpPrimitive.Controls.Add(this.rbString);
			this.tpPrimitive.Location = new System.Drawing.Point(4, 22);
			this.tpPrimitive.Name = "tpPrimitive";
			this.tpPrimitive.Padding = new System.Windows.Forms.Padding(3);
			this.tpPrimitive.Size = new System.Drawing.Size(509, 271);
			this.tpPrimitive.TabIndex = 0;
			this.tpPrimitive.Text = "Primitive Type";
			this.tpPrimitive.UseVisualStyleBackColor = true;
			// 
			// rbString
			// 
			this.rbString.AutoSize = true;
			this.rbString.Location = new System.Drawing.Point(6, 6);
			this.rbString.Name = "rbString";
			this.rbString.Size = new System.Drawing.Size(52, 17);
			this.rbString.TabIndex = 0;
			this.rbString.TabStop = true;
			this.rbString.Text = "String";
			this.rbString.UseVisualStyleBackColor = true;
			// 
			// rbInteger
			// 
			this.rbInteger.AutoSize = true;
			this.rbInteger.Location = new System.Drawing.Point(7, 30);
			this.rbInteger.Name = "rbInteger";
			this.rbInteger.Size = new System.Drawing.Size(58, 17);
			this.rbInteger.TabIndex = 1;
			this.rbInteger.TabStop = true;
			this.rbInteger.Text = "Integer";
			this.rbInteger.UseVisualStyleBackColor = true;
			// 
			// rbDouble
			// 
			this.rbDouble.AutoSize = true;
			this.rbDouble.Location = new System.Drawing.Point(7, 54);
			this.rbDouble.Name = "rbDouble";
			this.rbDouble.Size = new System.Drawing.Size(59, 17);
			this.rbDouble.TabIndex = 2;
			this.rbDouble.TabStop = true;
			this.rbDouble.Text = "Double";
			this.rbDouble.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(73, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(191, 20);
			this.textBox1.TabIndex = 3;
			// 
			// VariableEditorForm
			// 
			this.AcceptButton = this.btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnCancel;
			this.ClientSize = new System.Drawing.Size(542, 351);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.btnCancel);
			this.Name = "VariableEditorForm";
			this.Text = "Variable Selector";
			this.tabControl1.ResumeLayout(false);
			this.tpPrimitive.ResumeLayout(false);
			this.tpPrimitive.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpPrimitive;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.RadioButton rbDouble;
		private System.Windows.Forms.RadioButton rbInteger;
		private System.Windows.Forms.RadioButton rbString;
	}
}