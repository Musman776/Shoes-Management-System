using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes_Management_System
{
    public partial class Categ_Form : Form
    {
        public Categ_Form()
        {
            InitializeComponent();
        }

        private void categSave_btn_Click(object sender, EventArgs e)
        {
            if (categ_id_txt.Text == "" && categ_txt.Text == "") 
            {
                MessageBox.Show("Empty field not allowd");
            }
            else
            {
                try
                {
                    String connString = Properties.Settings.Default.connString;
                    SqlConnection con = new SqlConnection(connString);
                    con.Open();
                    String query = $"INSERT INTO Category (id,type) VALUES (@id,@type)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", categ_id_txt.Text);
                    cmd.Parameters.AddWithValue("@type", categ_txt.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Saved");
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               

            }
        }

       
    }
}
