﻿namespace Xanatos.Editor
{
	partial class MapView
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
			this.glControl = new OpenTK.GLControl();
			this.SuspendLayout();
			// 
			// glControl
			// 
			this.glControl.BackColor = System.Drawing.Color.Black;
			this.glControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.glControl.Location = new System.Drawing.Point(0, 0);
			this.glControl.Name = "glControl";
			this.glControl.Size = new System.Drawing.Size(556, 441);
			this.glControl.TabIndex = 1;
			this.glControl.VSync = false;
			this.glControl.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl_Paint);
			this.glControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseDown);
			this.glControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.glControl_MouseMove);
			// 
			// MapView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.glControl);
			this.Name = "MapView";
			this.Size = new System.Drawing.Size(556, 441);
			this.Load += new System.EventHandler(this.MapView_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private OpenTK.GLControl glControl;
	}
}
