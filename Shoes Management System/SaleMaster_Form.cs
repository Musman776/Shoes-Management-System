using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shoes_Management_System
{
    public partial class SaleMaster_Form : Form
    {
        public SaleMaster_Form()
        {
            InitializeComponent();


        }

        private void SaleMaster_Form_Load(object sender, EventArgs e)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string Update_query = "SELECT * FROM Sales_Master";
                SqlCommand cmd = new SqlCommand(Update_query, con);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    sale_gridList.Rows.Add(reader["ID"],  reader["Total_sale"]);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());
            }
        }
    }
}
