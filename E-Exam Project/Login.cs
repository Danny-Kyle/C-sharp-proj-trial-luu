/*
 * Created by SharpDevelop.
 * User: diked
 * Date: 30/06/2023
 * Time: 20:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace E_Exam_Project
{
	/// <summary>
	/// Description of Login.
	/// </summary>
	public partial class Login : Form
	{
		public Login()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			MySqlCommand command;
			MySqlDataReader mdr;
			string selectQuery = "SELECT * FROM FROM loginform.userinfo WHERE Username = '" + txtUsername.Text + "' AND Password = '" + txtPassword.Text + "';";
			MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
			mdr = command.ExecuteReader();
			if (mdr.Read())
			{
				string MyConnection2 = "datasource=localhost;port=3306;username=root;password=";
				string Query = "update loginform.userinfo set LastLogin='" + dateTimePicker1.Value + "' where Username='" + this.txtUsername.Text + "';";
				MySqlConnection MyConn2 = new MySqlConnection(MyConnection2);
				
				MySqlCommand MyCommand2 = new MySqlCommand(Query, MyConn2);
				MySqlDataReader MyReader2;
				MyConn2.Open();
				MyReader2 = MyCommand2.ExecuteReader();
				while (MyReader2.Read())
				{
				}
				MyConn2.Close();
				
				MessageBox.Show("Login Successful!");
				this.Hide();
				LoginSuccessForm frm2 = new LoginSuccessForm();
				frm2.ShowDialog();
			}
			else
			{
				MessageBox.Show("Incorrect Login Information! Try again.");
			}
			connection.Close();
			if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
			{
				MessageBox.Show("Please Input Username and Password", "Err");
			}
		}
	}
}
