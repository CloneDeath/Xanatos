namespace Xanatos.Editor
{
	partial class XanatosEditor
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
			this.msTopBar = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.dataEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eventEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpMapInfo = new System.Windows.Forms.TabPage();
			this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.glControl = new OpenTK.GLControl();
			this.msTopBar.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tpMapInfo.SuspendLayout();
			this.SuspendLayout();
			// 
			// msTopBar
			// 
			this.msTopBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
			this.msTopBar.Location = new System.Drawing.Point(0, 0);
			this.msTopBar.Name = "msTopBar";
			this.msTopBar.Size = new System.Drawing.Size(982, 24);
			this.msTopBar.TabIndex = 0;
			this.msTopBar.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.loadToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newToolStripMenuItem
			// 
			this.newToolStripMenuItem.Name = "newToolStripMenuItem";
			this.newToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.newToolStripMenuItem.Text = "New...";
			this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// saveAsToolStripMenuItem
			// 
			this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
			this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.saveAsToolStripMenuItem.Text = "Save As...";
			this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
			// 
			// loadToolStripMenuItem
			// 
			this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
			this.loadToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
			this.loadToolStripMenuItem.Text = "Load...";
			this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
			// 
			// viewToolStripMenuItem
			// 
			this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataEditorToolStripMenuItem,
            this.eventEditorToolStripMenuItem});
			this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.viewToolStripMenuItem.Text = "View";
			// 
			// dataEditorToolStripMenuItem
			// 
			this.dataEditorToolStripMenuItem.Name = "dataEditorToolStripMenuItem";
			this.dataEditorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.dataEditorToolStripMenuItem.Text = "Data Editor";
			this.dataEditorToolStripMenuItem.Click += new System.EventHandler(this.dataEditorToolStripMenuItem_Click);
			// 
			// eventEditorToolStripMenuItem
			// 
			this.eventEditorToolStripMenuItem.Name = "eventEditorToolStripMenuItem";
			this.eventEditorToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
			this.eventEditorToolStripMenuItem.Text = "Event Editor";
			this.eventEditorToolStripMenuItem.Click += new System.EventHandler(this.eventEditorToolStripMenuItem_Click);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 24);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.glControl);
			this.splitContainer1.Size = new System.Drawing.Size(982, 555);
			this.splitContainer1.SplitterDistance = 327;
			this.splitContainer1.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpMapInfo);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(327, 555);
			this.tabControl1.TabIndex = 0;
			// 
			// tpMapInfo
			// 
			this.tpMapInfo.Controls.Add(this.propertyGrid1);
			this.tpMapInfo.Location = new System.Drawing.Point(4, 22);
			this.tpMapInfo.Name = "tpMapInfo";
			this.tpMapInfo.Padding = new System.Windows.Forms.Padding(3);
			this.tpMapInfo.Size = new System.Drawing.Size(319, 529);
			this.tpMapInfo.TabIndex = 0;
			this.tpMapInfo.Text = "Map Info";
			this.tpMapInfo.UseVisualStyleBackColor = true;
			// 
			// propertyGrid1
			// 
			this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
			this.propertyGrid1.Name = "propertyGrid1";
			this.propertyGrid1.Size = new System.Drawing.Size(313, 523);
			this.propertyGrid1.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(319, 529);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// glControl
			// 
			this.glControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.glControl.BackColor = System.Drawing.Color.Black;
			this.glControl.Location = new System.Drawing.Point(0, 0);
			this.glControl.Name = "glControl";
			this.glControl.Size = new System.Drawing.Size(651, 555);
			this.glControl.TabIndex = 0;
			this.glControl.VSync = false;
			this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
			// 
			// XanatosEditor
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(982, 579);
			this.Controls.Add(this.splitContainer1);
			this.Controls.Add(this.msTopBar);
			this.MainMenuStrip = this.msTopBar;
			this.Name = "XanatosEditor";
			this.Text = "Xanatos Editor";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.XanatosEditor_Load);
			this.msTopBar.ResumeLayout(false);
			this.msTopBar.PerformLayout();
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tpMapInfo.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip msTopBar;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dataEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eventEditorToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private OpenTK.GLControl glControl;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpMapInfo;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.PropertyGrid propertyGrid1;
	}
}

