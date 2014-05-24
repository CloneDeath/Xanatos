namespace Xanatos.Editor
{
	partial class DataItemsEditorControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.pgCurrentItem = new System.Windows.Forms.PropertyGrid();
			this.dgvDataItems = new System.Windows.Forms.DataGridView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.btnAddDataItem = new System.Windows.Forms.Button();
			this.btnDeleteDataItem = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDataItems)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pgCurrentItem
			// 
			this.pgCurrentItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pgCurrentItem.Location = new System.Drawing.Point(0, 0);
			this.pgCurrentItem.Name = "pgCurrentItem";
			this.pgCurrentItem.Size = new System.Drawing.Size(429, 504);
			this.pgCurrentItem.TabIndex = 0;
			// 
			// dgvDataItems
			// 
			this.dgvDataItems.AllowUserToAddRows = false;
			this.dgvDataItems.AllowUserToDeleteRows = false;
			this.dgvDataItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvDataItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDataItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgvDataItems.Location = new System.Drawing.Point(0, 0);
			this.dgvDataItems.Name = "dgvDataItems";
			this.dgvDataItems.ReadOnly = true;
			this.dgvDataItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvDataItems.Size = new System.Drawing.Size(292, 504);
			this.dgvDataItems.TabIndex = 1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.splitContainer1.Location = new System.Drawing.Point(0, 32);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.dgvDataItems);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.pgCurrentItem);
			this.splitContainer1.Size = new System.Drawing.Size(733, 508);
			this.splitContainer1.SplitterDistance = 296;
			this.splitContainer1.TabIndex = 2;
			// 
			// btnAddDataItem
			// 
			this.btnAddDataItem.Location = new System.Drawing.Point(0, 3);
			this.btnAddDataItem.Name = "btnAddDataItem";
			this.btnAddDataItem.Size = new System.Drawing.Size(75, 23);
			this.btnAddDataItem.TabIndex = 3;
			this.btnAddDataItem.Text = "Add";
			this.btnAddDataItem.UseVisualStyleBackColor = true;
			this.btnAddDataItem.Click += new System.EventHandler(this.btnAddDataItem_Click);
			// 
			// btnDeleteDataItem
			// 
			this.btnDeleteDataItem.Location = new System.Drawing.Point(219, 3);
			this.btnDeleteDataItem.Name = "btnDeleteDataItem";
			this.btnDeleteDataItem.Size = new System.Drawing.Size(75, 23);
			this.btnDeleteDataItem.TabIndex = 4;
			this.btnDeleteDataItem.Text = "Delete";
			this.btnDeleteDataItem.UseVisualStyleBackColor = true;
			this.btnDeleteDataItem.Click += new System.EventHandler(this.btnDeleteDataItem_Click);
			// 
			// DataItemsEditorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.btnDeleteDataItem);
			this.Controls.Add(this.btnAddDataItem);
			this.Controls.Add(this.splitContainer1);
			this.Name = "DataItemsEditorControl";
			this.Size = new System.Drawing.Size(733, 543);
			((System.ComponentModel.ISupportInitialize)(this.dgvDataItems)).EndInit();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PropertyGrid pgCurrentItem;
		private System.Windows.Forms.DataGridView dgvDataItems;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button btnAddDataItem;
		private System.Windows.Forms.Button btnDeleteDataItem;
	}
}
