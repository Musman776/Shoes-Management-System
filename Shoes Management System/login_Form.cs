using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using MaterialSkin.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using MessageBox = System.Windows.MessageBox;

namespace Shoes_Management_System
{

    public partial class login_Form : Form
    {
       
        public login_Form()
        {
            InitializeComponent(); 
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string username = "";
            string password = "";
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = $"SELECT TOP 1 username, Password FROM SignUp;";

                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {

                    username = r.GetString(r.GetOrdinal("username"));
                    password = r.GetString(r.GetOrdinal("Password"));



                }
                r.Close();
                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }


            if (email_txt.Text == username && login_pass_txt.Text == password)
            {

                MainForm mainform = new MainForm();
                
                login_Form login_Form = new login_Form();
                login_Form.Close();
                mainform.Show();
            }
            else
            {
                MessageBox.Show("Incorrect password");
            }


        }
            



           
      

        private void signup_btn_Click(object sender, EventArgs e)
        {
            Sign_Up sign_Up = new Sign_Up();
            sign_Up.Show();
        }
    }
}
