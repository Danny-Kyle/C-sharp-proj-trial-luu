/*
 * Created by SharpDevelop.
 * User: diked
 * Date: 30/06/2023
 * Time: 20:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Exam_Project
{
	/// <summary>
	/// Description of Homepage.
	/// </summary>
	public partial class Homepage : Form
	{
		public Homepage()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button2Click(object sender, EventArgs e)
		{
	
		}
		void BtnlogoutClick(object sender, EventArgs e)
		{
			this.Hide();
			Login log = new Login();
			log.ShowDialog();
		}
		
	}
}
