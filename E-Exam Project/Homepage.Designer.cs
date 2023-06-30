/*
 * Created by SharpDevelop.
 * User: diked
 * Date: 30/06/2023
 * Time: 20:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace E_Exam_Project
{
	partial class Homepage
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnlogout;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		
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
			this.btnlogout = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnlogout
			// 
			this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnlogout.ForeColor = System.Drawing.Color.OrangeRed;
			this.btnlogout.Location = new System.Drawing.Point(546, 12);
			this.btnlogout.Name = "btnlogout";
			this.btnlogout.Size = new System.Drawing.Size(90, 68);
			this.btnlogout.TabIndex = 0;
			this.btnlogout.Text = "Logout";
			this.btnlogout.UseVisualStyleBackColor = true;
			this.btnlogout.Click += new System.EventHandler(this.BtnlogoutClick);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(455, 263);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(172, 142);
			this.button2.TabIndex = 1;
			this.button2.Text = "Proceed to Exam page";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(45, 116);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(175, 29);
			this.label1.TabIndex = 2;
			this.label1.Text = "Candidate Eligibility";
			// 
			// Homepage
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(648, 435);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.btnlogout);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Homepage";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Homepage";
			this.ResumeLayout(false);

		}
	}
}
