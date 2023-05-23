using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using MessageBox = System.Windows.MessageBox;

namespace Shoes_Management_System
{
    public partial class Sign_Up : Form
    {
       

      
        public Sign_Up()
        {
            InitializeComponent();
           
        }

        private void signup_btn_Click(object sender, EventArgs e)
        {

            String UserName = uname_txt.Text;
            String FirstName = fname_txt.Text;
            String LastName = lname_txt.Text;
            String PhoneNo = phone_no_txt.Text;
            String Password = password_txt.Text;
            String CompanyName = comp_name_txt.Text;
            String Discription = disc_txt.Text;
            String conform_pass = c_password_txt.Text;


            if (FirstName == string.Empty)
            {
                fname_txt.Focus();
                fname_txt.PlaceholderText = "Field is empty";
                fname_txt.PlaceholderForeColor = Color.Red;
            }
            else if (LastName == string.Empty)
            {
                lname_txt.Focus();
                lname_txt.PlaceholderText = "Field is empty";
                lname_txt.PlaceholderForeColor = Color.Red;
            }
            else if (UserName == string.Empty)
            {
                uname_txt.Focus();
                uname_txt.PlaceholderText = "Field is empty";
                uname_txt.PlaceholderForeColor = Color.Red;

            }
            else if (PhoneNo == string.Empty)
            {
                phone_no_txt.Focus();
            }
            else if (Password == string.Empty)
            {
                password_txt.Focus();
                password_txt.PlaceholderText = "Field is empty";
                password_txt.PlaceholderForeColor = Color.Red;

            }
            else if (CompanyName == string.Empty)
            {
                comp_name_txt.Focus();
                comp_name_txt.PlaceholderText = "Field is empty";
                comp_name_txt.PlaceholderForeColor = Color.Red;

            }
            else if (Discription == string.Empty)
            {
                disc_txt.Focus();
                disc_txt.PlaceholderText = "Field is empty";
                disc_txt.PlaceholderForeColor = Color.Red;

            }
            else if (c_password_txt.Text == string.Empty)
            {
                c_password_txt.Focus();
                c_password_txt.PlaceholderText = "Field is empty";
                c_password_txt.PlaceholderForeColor = Color.Red;

            }
            else {
                fname_txt.PlaceholderForeColor = Color.DarkGray;
                lname_txt.PlaceholderForeColor = Color.DarkGray;
                uname_txt.PlaceholderForeColor = Color.DarkGray;
                password_txt.PlaceholderForeColor = Color.DarkGray;
                c_password_txt.PlaceholderForeColor = Color.DarkGray;
                comp_name_txt.PlaceholderForeColor = Color.DarkGray;
                disc_txt.PlaceholderForeColor = Color.DarkGray;

                if (Password == conform_pass)
                {

                    try
                    {

                        String connString = Properties.Settings.Default.connString;
                        SqlConnection con = new SqlConnection(connString);
                        con.Open();
                        string Update_query = "insert into SignUp(username,Fname,Lname,Password,Phone_no,Comp_name,Disc) values(@username ,@Fname ,@Lname ,@Password ,@Phone_no ,@Com_name ,@Disc)";
                        SqlCommand cmd = new SqlCommand(Update_query, con);
                        cmd.Parameters.AddWithValue("@username", UserName);
                        cmd.Parameters.AddWithValue("@Fname", FirstName);
                        cmd.Parameters.AddWithValue("@Lname", LastName);
                        cmd.Parameters.AddWithValue("@Password", Password);
                        cmd.Parameters.AddWithValue("@Phone_no", PhoneNo);
                        cmd.Parameters.AddWithValue("@Com_name", CompanyName);
                        cmd.Parameters.AddWithValue("@Disc", Discription);

                        cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("saved");

                        this.Close();

                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("ERORR:" + ex.ToString());
                    }

                }
                else {
                    MessageBox.Show("Mismatch password");
                }

            }




           
                  
                

            }



        }
    }
