using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Shoes_Management_System
{
    public partial class Manage_Form : Form
    {

        public Manage_Form()
        {
            InitializeComponent();
        }

        private void Manage_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'footware_dbDataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.footware_dbDataSet.Category);






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
                    editList_gridview.Rows.Add(reader["ID"], reader["Category"], reader["Modal"], reader["Tag_no"], reader["Current_stock"], reader["Price"], reader["Size_us"], reader["Other_detail"]);
                }

                con.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());
                this.Close();
            }
        }



        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string query= "INSERT INTO Product(ID,Category,Modal,Tag_no,Current_stock,Price,Size_us,Other_detail) values(@ID,@Category,@Modal,@Tag_no,@Current_stock,@Price,@Size_us,@Other_detail)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id_txt.Text);
                cmd.Parameters.AddWithValue("@Category", categ_comb.SelectedValue);
                cmd.Parameters.AddWithValue("@Modal", modal_txt.Text);
                cmd.Parameters.AddWithValue("@Tag_no", tag_txt.Text);
                cmd.Parameters.AddWithValue("@Current_stock", stock_txt.Text);
                cmd.Parameters.AddWithValue("@Price", price_txt.Text);
                cmd.Parameters.AddWithValue("@Size_us", size_txt.Text);
                cmd.Parameters.AddWithValue("@Other_detail", desc_txt.Text);
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Saved");
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void editList_gridview_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 8)
            {
                try
                {
                    int id = (int)editList_gridview.Rows[e.RowIndex].Cells[0].Value;
                    string modal = editList_gridview.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string tag = editList_gridview.Rows[e.RowIndex].Cells[3].Value.ToString();
                    int to_sale = (int)editList_gridview.Rows[e.RowIndex].Cells[4].Value;
                    decimal price = (decimal)editList_gridview.Rows[e.RowIndex].Cells[5].Value;
                    int size = (int)editList_gridview.Rows[e.RowIndex].Cells[6].Value;
                    string desc = editList_gridview.Rows[e.RowIndex].Cells[7].Value.ToString();


                    id_txt.Text = id.ToString();
                    modal_txt.Text = modal;
                    tag_txt.Text = tag.ToString();
                    stock_txt.Text = to_sale.ToString();
                    price_txt.Text = price.ToString();
                    size_txt.Text = size.ToString();
                    desc_txt.Text = desc.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERORR:" + ex.ToString());
                    this.Close();
                }
            }

        }

        private void Update_btn_Click_1(object sender, EventArgs e)
        {
            Update_prod();
        }


        private void Update_prod()
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open(); 
                string query= $"UPDATE Product SET Category= @Category , Modal= @Modal, Tag_no= @Tag_no,Current_stock= @Current_stock ,Price= @Price ,Size_us= @Size_us ,Other_detail= @Other_detail  WHERE ID =@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id_txt.Text);
                cmd.Parameters.AddWithValue("@Category", categ_comb.SelectedValue);
                cmd.Parameters.AddWithValue("@Modal", modal_txt.Text);
                cmd.Parameters.AddWithValue("@Tag_no", tag_txt.Text);
                cmd.Parameters.AddWithValue("@Current_stock", stock_txt.Text);
                cmd.Parameters.AddWithValue("@Price", price_txt.Text);
                cmd.Parameters.AddWithValue("@Size_us", size_txt.Text);
                cmd.Parameters.AddWithValue("@Other_detail", desc_txt.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Updated");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());
                this.Close();
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string query = $"DELETE FROM Product WHERE ID =@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id_txt.Text);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Delete");

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());
                this.Close();
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                String connString = Properties.Settings.Default.connString;
                SqlConnection con = new SqlConnection(connString);
                con.Open();
                string query = $"SELECT  Category,Modal,Tag_no,Current_stock,Price,Size_us,Other_detail FROM Product WHERE ID =@ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@ID", id_txt.Text);
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    id_txt.ReadOnly = true;
                   
                    categ_comb.SelectedValue = r.GetString(r.GetOrdinal("Category"));
                    modal_txt.Text = r.GetString(r.GetOrdinal("Modal"));
                    tag_txt.Text = r.GetString(r.GetOrdinal("Tag_no"));
                    stock_txt.Text = r.GetInt32(r.GetOrdinal("Current_stock")).ToString();
                    price_txt.Text = r.GetDecimal(r.GetOrdinal("Price")).ToString();
                    size_txt.Text = r.GetInt32(r.GetOrdinal("Size_us")).ToString();
                    desc_txt.Text = r.GetString(r.GetOrdinal("Other_detail"));


                }
                
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERORR:" + ex.ToString());
            }
        }

    }
}
