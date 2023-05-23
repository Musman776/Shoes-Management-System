namespace Shoes_Management_System
{
    partial class Categ_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.categ_id_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.categSave_btn = new Guna.UI2.WinForms.Guna2Button();
            this.categ_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // categ_id_txt
            // 
            this.categ_id_txt.Animated = true;
            this.categ_id_txt.BackColor = System.Drawing.SystemColors.Control;
            this.categ_id_txt.BorderRadius = 6;
            this.categ_id_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categ_id_txt.DefaultText = "";
            this.categ_id_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categ_id_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categ_id_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categ_id_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categ_id_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categ_id_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_id_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categ_id_txt.Location = new System.Drawing.Point(61, 186);
            this.categ_id_txt.Name = "categ_id_txt";
            this.categ_id_txt.PasswordChar = '\0';
            this.categ_id_txt.PlaceholderText = "";
            this.categ_id_txt.SelectedText = "";
            this.categ_id_txt.Size = new System.Drawing.Size(227, 41);
            this.categ_id_txt.TabIndex = 1;
            // 
            // categSave_btn
            // 
            this.categSave_btn.Animated = true;
            this.categSave_btn.BorderRadius = 7;
            this.categSave_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.categSave_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.categSave_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.categSave_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.categSave_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(201)))), ((int)(((byte)(112)))));
            this.categSave_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.categSave_btn.ForeColor = System.Drawing.Color.White;
            this.categSave_btn.IndicateFocus = true;
            this.categSave_btn.Location = new System.Drawing.Point(122, 375);
            this.categSave_btn.Name = "categSave_btn";
            this.categSave_btn.Size = new System.Drawing.Size(106, 40);
            this.categSave_btn.TabIndex = 2;
            this.categSave_btn.Text = "Save";
            this.categSave_btn.Click += new System.EventHandler(this.categSave_btn_Click);
            // 
            // categ_txt
            // 
            this.categ_txt.Animated = true;
            this.categ_txt.BackColor = System.Drawing.SystemColors.Control;
            this.categ_txt.BorderRadius = 6;
            this.categ_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.categ_txt.DefaultText = "";
            this.categ_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.categ_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.categ_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categ_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.categ_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categ_txt.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categ_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categ_txt.Location = new System.Drawing.Point(61, 286);
            this.categ_txt.Name = "categ_txt";
            this.categ_txt.PasswordChar = '\0';
            this.categ_txt.PlaceholderText = "";
            this.categ_txt.SelectedText = "";
            this.categ_txt.Size = new System.Drawing.Size(227, 41);
            this.categ_txt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(117, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Category";
            // 
            // Categ_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(382, 681);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.categ_txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.categSave_btn);
            this.Controls.Add(this.categ_id_txt);
            this.Controls.Add(this.label1);
            this.Name = "Categ_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox categ_id_txt;
        private Guna.UI2.WinForms.Guna2Button categSave_btn;
        private Guna.UI2.WinForms.Guna2TextBox categ_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}