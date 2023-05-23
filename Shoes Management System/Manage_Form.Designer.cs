namespace Shoes_Management_System
{
    partial class Manage_Form
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
            this.components = new System.ComponentModel.Container();
            this.editList_gridview = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.id_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.modal_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tag_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.stock_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.price_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.size_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.desc_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Save = new Guna.UI2.WinForms.Guna2Button();
            this.delete_btn = new Guna.UI2.WinForms.Guna2Button();
            this.search_btn = new Guna.UI2.WinForms.Guna2Button();
            this.footware_dbDataSet = new Shoes_Management_System.Footware_dbDataSet();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoryTableAdapter = new Shoes_Management_System.Footware_dbDataSetTableAdapters.CategoryTableAdapter();
            this.categ_comb = new System.Windows.Forms.ComboBox();
            this.Update_btn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.editList_gridview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footware_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // editList_gridview
            // 
            this.editList_gridview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editList_gridview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.editList_gridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.editList_gridview.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.editList_gridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.editList_gridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column9,
            this.Column10});
            this.editList_gridview.Location = new System.Drawing.Point(424, 12);
            this.editList_gridview.MultiSelect = false;
            this.editList_gridview.Name = "editList_gridview";
            this.editList_gridview.RowHeadersWidth = 51;
            this.editList_gridview.RowTemplate.Height = 24;
            this.editList_gridview.Size = new System.Drawing.Size(626, 649);
            this.editList_gridview.TabIndex = 0;
            this.editList_gridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.editList_gridview_CellContentClick_1);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Category";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Modal";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tag#";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Stock";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Price";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Size";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Detail";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Column10.HeaderText = "Edit";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column10.Text = "Edit";
            this.Column10.UseColumnTextForButtonValue = true;
            // 
            // id_txt
            // 
            this.id_txt.Animated = true;
            this.id_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.id_txt.BorderRadius = 6;
            this.id_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.id_txt.DefaultText = "";
            this.id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.id_txt.ForeColor = System.Drawing.Color.Black;
            this.id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.id_txt.Location = new System.Drawing.Point(14, 101);
            this.id_txt.Name = "id_txt";
            this.id_txt.PasswordChar = '\0';
            this.id_txt.PlaceholderText = "ID";
            this.id_txt.SelectedText = "";
            this.id_txt.Size = new System.Drawing.Size(164, 40);
            this.id_txt.TabIndex = 1;
            // 
            // modal_txt
            // 
            this.modal_txt.Animated = true;
            this.modal_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.modal_txt.BorderRadius = 6;
            this.modal_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.modal_txt.DefaultText = "";
            this.modal_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.modal_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.modal_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modal_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.modal_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modal_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.modal_txt.ForeColor = System.Drawing.Color.Black;
            this.modal_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.modal_txt.Location = new System.Drawing.Point(14, 160);
            this.modal_txt.Name = "modal_txt";
            this.modal_txt.PasswordChar = '\0';
            this.modal_txt.PlaceholderText = "Modal";
            this.modal_txt.SelectedText = "";
            this.modal_txt.Size = new System.Drawing.Size(386, 40);
            this.modal_txt.TabIndex = 2;
            // 
            // tag_txt
            // 
            this.tag_txt.Animated = true;
            this.tag_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.tag_txt.BorderRadius = 6;
            this.tag_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tag_txt.DefaultText = "";
            this.tag_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tag_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tag_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tag_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tag_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tag_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.tag_txt.ForeColor = System.Drawing.Color.Black;
            this.tag_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tag_txt.Location = new System.Drawing.Point(14, 225);
            this.tag_txt.Name = "tag_txt";
            this.tag_txt.PasswordChar = '\0';
            this.tag_txt.PlaceholderText = "Tag#";
            this.tag_txt.SelectedText = "";
            this.tag_txt.Size = new System.Drawing.Size(164, 40);
            this.tag_txt.TabIndex = 3;
            // 
            // stock_txt
            // 
            this.stock_txt.Animated = true;
            this.stock_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.stock_txt.BorderRadius = 6;
            this.stock_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock_txt.DefaultText = "";
            this.stock_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stock_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stock_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stock_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.stock_txt.ForeColor = System.Drawing.Color.Black;
            this.stock_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.stock_txt.Location = new System.Drawing.Point(196, 225);
            this.stock_txt.Name = "stock_txt";
            this.stock_txt.PasswordChar = '\0';
            this.stock_txt.PlaceholderText = "Stock";
            this.stock_txt.SelectedText = "";
            this.stock_txt.Size = new System.Drawing.Size(204, 40);
            this.stock_txt.TabIndex = 4;
            // 
            // price_txt
            // 
            this.price_txt.Animated = true;
            this.price_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.price_txt.BorderRadius = 6;
            this.price_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price_txt.DefaultText = "";
            this.price_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.price_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.price_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.price_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.price_txt.ForeColor = System.Drawing.Color.Black;
            this.price_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.price_txt.Location = new System.Drawing.Point(14, 297);
            this.price_txt.Name = "price_txt";
            this.price_txt.PasswordChar = '\0';
            this.price_txt.PlaceholderText = "Price";
            this.price_txt.SelectedText = "";
            this.price_txt.Size = new System.Drawing.Size(164, 40);
            this.price_txt.TabIndex = 5;
            // 
            // size_txt
            // 
            this.size_txt.Animated = true;
            this.size_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.size_txt.BorderRadius = 6;
            this.size_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.size_txt.DefaultText = "";
            this.size_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.size_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.size_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.size_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.size_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.size_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.size_txt.ForeColor = System.Drawing.Color.Black;
            this.size_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.size_txt.Location = new System.Drawing.Point(196, 297);
            this.size_txt.Name = "size_txt";
            this.size_txt.PasswordChar = '\0';
            this.size_txt.PlaceholderText = "Size";
            this.size_txt.SelectedText = "";
            this.size_txt.Size = new System.Drawing.Size(204, 40);
            this.size_txt.TabIndex = 6;
            // 
            // desc_txt
            // 
            this.desc_txt.Animated = true;
            this.desc_txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.desc_txt.BorderRadius = 6;
            this.desc_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.desc_txt.DefaultText = "";
            this.desc_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.desc_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.desc_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.desc_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.desc_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.desc_txt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.desc_txt.ForeColor = System.Drawing.Color.Black;
            this.desc_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.desc_txt.Location = new System.Drawing.Point(12, 501);
            this.desc_txt.Multiline = true;
            this.desc_txt.Name = "desc_txt";
            this.desc_txt.PasswordChar = '\0';
            this.desc_txt.PlaceholderText = "Desciption";
            this.desc_txt.SelectedText = "";
            this.desc_txt.Size = new System.Drawing.Size(388, 45);
            this.desc_txt.TabIndex = 7;
            // 
            // Save
            // 
            this.Save.Animated = true;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.BorderRadius = 6;
            this.Save.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Save.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Save.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Save.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.Save.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.IndicateFocus = true;
            this.Save.Location = new System.Drawing.Point(14, 595);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(120, 35);
            this.Save.TabIndex = 10;
            this.Save.Text = "Save";
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Animated = true;
            this.delete_btn.BackColor = System.Drawing.Color.Transparent;
            this.delete_btn.BorderRadius = 6;
            this.delete_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.delete_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.IndicateFocus = true;
            this.delete_btn.Location = new System.Drawing.Point(140, 595);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(120, 35);
            this.delete_btn.TabIndex = 11;
            this.delete_btn.Text = "Delete";
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Animated = true;
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.BorderRadius = 6;
            this.search_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.search_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.IndicateFocus = true;
            this.search_btn.Location = new System.Drawing.Point(67, 40);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(180, 40);
            this.search_btn.TabIndex = 13;
            this.search_btn.Text = "Search";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // footware_dbDataSet
            // 
            this.footware_dbDataSet.DataSetName = "Footware_dbDataSet";
            this.footware_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataMember = "Category";
            this.categoryBindingSource.DataSource = this.footware_dbDataSet;
            // 
            // categoryTableAdapter
            // 
            this.categoryTableAdapter.ClearBeforeFill = true;
            // 
            // categ_comb
            // 
            this.categ_comb.DataSource = this.categoryBindingSource;
            this.categ_comb.DisplayMember = "type";
            this.categ_comb.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_comb.FormattingEnabled = true;
            this.categ_comb.Location = new System.Drawing.Point(196, 105);
            this.categ_comb.Name = "categ_comb";
            this.categ_comb.Size = new System.Drawing.Size(204, 31);
            this.categ_comb.TabIndex = 14;
            this.categ_comb.ValueMember = "type";
            // 
            // Update_btn
            // 
            this.Update_btn.Animated = true;
            this.Update_btn.BackColor = System.Drawing.Color.Transparent;
            this.Update_btn.BorderRadius = 6;
            this.Update_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Update_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Update_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Update_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Update_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.Update_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.Update_btn.ForeColor = System.Drawing.Color.White;
            this.Update_btn.IndicateFocus = true;
            this.Update_btn.Location = new System.Drawing.Point(266, 595);
            this.Update_btn.Name = "Update_btn";
            this.Update_btn.Size = new System.Drawing.Size(120, 35);
            this.Update_btn.TabIndex = 15;
            this.Update_btn.Text = "Update";
            this.Update_btn.Click += new System.EventHandler(this.Update_btn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Shoes_Management_System.Properties.Resources.green_pedestal_podium_product_display_stand_empty_space_stage_studio_background_3d_rendering;
            this.pictureBox1.InitialImage = global::Shoes_Management_System.Properties.Resources.image_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(21, 355);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Manage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.Update_btn);
            this.Controls.Add(this.categ_comb);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.desc_txt);
            this.Controls.Add(this.size_txt);
            this.Controls.Add(this.price_txt);
            this.Controls.Add(this.stock_txt);
            this.Controls.Add(this.tag_txt);
            this.Controls.Add(this.modal_txt);
            this.Controls.Add(this.id_txt);
            this.Controls.Add(this.editList_gridview);
            this.Name = "Manage_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage";
            this.Load += new System.EventHandler(this.Manage_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editList_gridview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footware_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView editList_gridview;
        private Guna.UI2.WinForms.Guna2TextBox id_txt;
        private Guna.UI2.WinForms.Guna2TextBox modal_txt;
        private Guna.UI2.WinForms.Guna2TextBox tag_txt;
        private Guna.UI2.WinForms.Guna2TextBox stock_txt;
        private Guna.UI2.WinForms.Guna2TextBox price_txt;
        private Guna.UI2.WinForms.Guna2TextBox size_txt;
        private Guna.UI2.WinForms.Guna2TextBox desc_txt;
        private Guna.UI2.WinForms.Guna2Button Save;
        private Guna.UI2.WinForms.Guna2Button delete_btn;
        private Guna.UI2.WinForms.Guna2Button search_btn;
        private Footware_dbDataSet footware_dbDataSet;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private Footware_dbDataSetTableAdapters.CategoryTableAdapter categoryTableAdapter;
        private System.Windows.Forms.ComboBox categ_comb;
        private Guna.UI2.WinForms.Guna2Button Update_btn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewButtonColumn Column10;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}