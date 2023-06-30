/*
 * Created by SharpDevelop.
 * User: diked
 * Date: 30/06/2023
 * Time: 20:31
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Exam_Project
{
	/// <summary>
	/// Description of PreExamCounter.
	/// </summary>
	public partial class PreExamCounter : Form
	{
		public PreExamCounter()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		int startpoint = 15;
		private void Timer1Tick(object sender, EventArgs e)
		{
			startpoint -= 1;
			if(startpoint == 10)
			{
				timer1.Stop();
				this.Hide();
				ExamPage ep = new ExamPage();
				ep.Show();
			}
		}
		void PreExamCounterLoad(object sender, EventArgs e)
		{
			timer1.Start();
		}
	}
}
