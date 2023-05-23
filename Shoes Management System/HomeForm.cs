using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Shoes_Management_System
{
    public partial class HomeForm : Form
    {
        int current_stock = 0;
        int new_stock = 0;
        int sale_Mas = 0;

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
 try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string Update_query = "SELECT * FROM Product";
                SqlCommand cmd = new SqlCommand(Update_query, con);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["ID"], reader["Category"], reader["Modal"], reader["Tag_no"], reader["Current_stock"], reader["Price"], reader["Size_us"], reader["Other_detail"]);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());
                this.Close();
            }


        }






        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (e.ColumnIndex == 8)
            {

                current_stock = (int)dataGridView1.Rows[e.RowIndex].Cells[4].Value;
                new_stock = current_stock - 1;
                sale_Mas = sale_Mas + 1;




                Parchase((int)dataGridView1.Rows[e.RowIndex].Cells[0].Value);


            }

        }







        private void Parchase(int p_id)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string Update_query = "SELECT id FROM Sales_Master";
                SqlCommand cmd = new SqlCommand(Update_query, con);

                var reader = cmd.ExecuteReader();

                while (reader.Read())
                {


                    if (p_id == Convert.ToInt32(reader["ID"]))
                    {
                        Update_Stock(p_id);
                        con.Close();
                        return;
                    }



                }

                con.Close();
                Add_New_Sale(p_id);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void Update_Stock(int p_id)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string update_q
       = $"Update Sales_Master SET Total_sale = @Sale WHERE id = @ID";
                SqlCommand cmd = new SqlCommand(update_q, con);
                cmd.Parameters.AddWithValue("@ID", p_id);
                cmd.Parameters.AddWithValue("@sale", sale_Mas);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string update_q
       = $"Update Product SET Current_Stock = @Sale WHERE ID = @ID";
                SqlCommand cmd = new SqlCommand(update_q, con);
                cmd.Parameters.AddWithValue("@ID", p_id);
                cmd.Parameters.AddWithValue("@sale", new_stock);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void Add_New_Sale(int p_id)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string update_q= $"INSERT INTO Sales_Master(id,Total_sale) values(@ID,@Total_sale)";
                SqlCommand cmd = new SqlCommand(update_q, con);
                cmd.Parameters.AddWithValue("@ID", p_id);
                cmd.Parameters.AddWithValue("@Total_sale", sale_Mas);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Print");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }




        private void Master_saleCount()
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string Update_query = "SELECT (Total_sale) FROM Sales_Master WHERE (id) = (@ID)";
                SqlCommand cmd = new SqlCommand(Update_query, con);
                //cmd.Parameters.AddWithValue("@ID",);
                cmd.ExecuteNonQuery();
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        
    }
}
