namespace Shoes_Management_System
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.saleMaster_btn = new Guna.UI2.WinForms.Guna2Button();
            this.edit_btn = new Guna.UI2.WinForms.Guna2Button();
            this.category_btn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.saleMaster_btn);
            this.panel1.Controls.Add(this.edit_btn);
            this.panel1.Controls.Add(this.category_btn);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(245, 720);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // saleMaster_btn
            // 
            this.saleMaster_btn.Animated = true;
            this.saleMaster_btn.BackColor = System.Drawing.Color.Transparent;
            this.saleMaster_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.saleMaster_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.saleMaster_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.saleMaster_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.saleMaster_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.saleMaster_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.saleMaster_btn.ForeColor = System.Drawing.Color.Black;
            this.saleMaster_btn.Image = global::Shoes_Management_System.Properties.Resources.business_and_finance;
            this.saleMaster_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.saleMaster_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.saleMaster_btn.IndicateFocus = true;
            this.saleMaster_btn.Location = new System.Drawing.Point(3, 465);
            this.saleMaster_btn.Name = "saleMaster_btn";
            this.saleMaster_btn.Size = new System.Drawing.Size(242, 60);
            this.saleMaster_btn.TabIndex = 4;
            this.saleMaster_btn.Text = "Sales";
            this.saleMaster_btn.Click += new System.EventHandler(this.saleMaster_btn_Click);
            // 
            // edit_btn
            // 
            this.edit_btn.Animated = true;
            this.edit_btn.BackColor = System.Drawing.Color.Transparent;
            this.edit_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.edit_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.edit_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.edit_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.edit_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.edit_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.edit_btn.ForeColor = System.Drawing.Color.Black;
            this.edit_btn.Image = global::Shoes_Management_System.Properties.Resources.editing;
            this.edit_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.edit_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.edit_btn.IndicateFocus = true;
            this.edit_btn.Location = new System.Drawing.Point(3, 365);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(242, 60);
            this.edit_btn.TabIndex = 3;
            this.edit_btn.Text = "Edit Item";
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // category_btn
            // 
            this.category_btn.Animated = true;
            this.category_btn.BackColor = System.Drawing.Color.Transparent;
            this.category_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.category_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.category_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.category_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.category_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.category_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_btn.ForeColor = System.Drawing.Color.Black;
            this.category_btn.Image = global::Shoes_Management_System.Properties.Resources.category;
            this.category_btn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.category_btn.ImageSize = new System.Drawing.Size(30, 30);
            this.category_btn.IndicateFocus = true;
            this.category_btn.Location = new System.Drawing.Point(3, 265);
            this.category_btn.Name = "category_btn";
            this.category_btn.Size = new System.Drawing.Size(242, 60);
            this.category_btn.TabIndex = 2;
            this.category_btn.Text = "Category";
            this.category_btn.Click += new System.EventHandler(this.category_btn_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.guna2Button1.ForeColor = System.Drawing.Color.Black;
            this.guna2Button1.Image = global::Shoes_Management_System.Properties.Resources.home;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button1.IndicateFocus = true;
            this.guna2Button1.Location = new System.Drawing.Point(3, 165);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(242, 60);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Home";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shoes_Management_System.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(67, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(245, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(835, 720);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Footware Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button saleMaster_btn;
        private Guna.UI2.WinForms.Guna2Button edit_btn;
        private Guna.UI2.WinForms.Guna2Button category_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}