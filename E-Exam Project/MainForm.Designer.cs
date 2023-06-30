/*
 * Created by SharpDevelop.
 * User: diked
 * Date: 30/06/2023
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace E_Exam_Project
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label confirmBox;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.button1 = new System.Windows.Forms.Button();
			this.confirmBox = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(94, 44);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(230, 75);
			this.button1.TabIndex = 0;
			this.button1.Text = "Check Connection Button";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// confirmBox
			// 
			this.confirmBox.Font = new System.Drawing.Font("Baskerville Old Face", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.confirmBox.ForeColor = System.Drawing.Color.Green;
			this.confirmBox.Location = new System.Drawing.Point(12, 167);
			this.confirmBox.Name = "confirmBox";
			this.confirmBox.Size = new System.Drawing.Size(429, 55);
			this.confirmBox.TabIndex = 1;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(453, 305);
			this.Controls.Add(this.confirmBox);
			this.Controls.Add(this.button1);
			this.Name = "MainForm";
			this.Text = "E-Exam Project";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.ResumeLayout(false);

		}
	}
}
