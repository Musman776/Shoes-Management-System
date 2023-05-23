using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shoes_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            HomeForm homeForm = new HomeForm();
            homeForm.Show();
        }

        private void category_btn_Click(object sender, EventArgs e)
        {
            Categ_Form categ_Form = new Categ_Form();
            categ_Form.Show();
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            Manage_Form manage_Form = new Manage_Form();
            manage_Form.Show();
        }

        private void saleMaster_btn_Click(object sender, EventArgs e)
        {
            SaleMaster_Form saleMaster_Form = new SaleMaster_Form();
            saleMaster_Form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ok");
        }
    }
}
