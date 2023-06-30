/*
 * Created by SharpDevelop.
 * User: diked
 * Date: 30/06/2023
 * Time: 10:32
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Exam_Project
{
	
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
//		private MySqlConnection conn ;
//		private string connectionstring	= "datasource=127.0.0.1;port=3306;username=root;password=;database=exams";
//		MySqlCommand command;
//		MySqlDataReader mdr;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		private void Button1Click(object sender, EventArgs e)
		{
			string connectionstring	= "datasource=127.0.0.1;port=3306;username=root;password=;database=exams";
			string query = "insert into info values (@fname, lname,)";
			MySqlConnection conn = new MySqlConnection(connectionstring);
			MySqlCommand cmd = new MySqlCommand(query, conn);
			conn.Open();
			try
			{
				conn.Open();
				confirmBox.Text = "Generated";
			}catch (MySqlException ex)
			{
				confirmBox.Text = "Error";
			}
//			dbconnect();
		}
//		private void dbconnect()
//		{
//			try {
//				conn.Open();
//				confirmBox.Text = "Connection Generated Successfully";
//			} catch (MySqlException ex) {
//				confirmBox.Text="Connect error";
////				MessageBox.Show("My SQL Connection!! \n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
//			}
//			
//		}
		void MainFormLoad(object sender, EventArgs e)
		{
//			dbconnect();
		}
	}
}
