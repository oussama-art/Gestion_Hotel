namespace Hotel
{
    partial class GuestForm1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_button = new System.Windows.Forms.Panel();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_fname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Lname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Phone = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.panel_button.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.White;
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 527);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(838, 100);
            this.panel_button.TabIndex = 0;
            this.panel_button.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_button_Paint);
            // 
            // button_clean
            // 
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.Image = global::Hotel.Properties.Resources.clean;
            this.button_clean.Location = new System.Drawing.Point(524, 0);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(177, 99);
            this.button_clean.TabIndex = 3;
            this.button_clean.Text = "Clean";
            this.button_clean.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_clean.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_clean.UseVisualStyleBackColor = true;
            this.button_clean.Click += new System.EventHandler(this.button_clean_Click);
            // 
            // button_delete
            // 
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Image = global::Hotel.Properties.Resources.delete;
            this.button_delete.Location = new System.Drawing.Point(351, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(177, 100);
            this.button_delete.TabIndex = 2;
            this.button_delete.Text = "Delete";
            this.button_delete.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_delete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_update
            // 
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_update.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Image = global::Hotel.Properties.Resources.update;
            this.button_update.Location = new System.Drawing.Point(178, 0);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(177, 99);
            this.button_update.TabIndex = 1;
            this.button_update.Text = "Update";
            this.button_update.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_update.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_save
            // 
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Image = global::Hotel.Properties.Resources.save;
            this.button_save.Location = new System.Drawing.Point(1, 0);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(177, 99);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Save";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(163, 401);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 32);
            this.textBox_id.TabIndex = 1;
            this.textBox_id.TextChanged += new System.EventHandler(this.textBox_id_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id No:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "First Name:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_fname
            // 
            this.textBox_fname.Location = new System.Drawing.Point(163, 451);
            this.textBox_fname.Name = "textBox_fname";
            this.textBox_fname.Size = new System.Drawing.Size(100, 32);
            this.textBox_fname.TabIndex = 3;
            this.textBox_fname.TextChanged += new System.EventHandler(this.textBox_fname_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 492);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Last Name:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBox_Lname
            // 
            this.textBox_Lname.Location = new System.Drawing.Point(163, 489);
            this.textBox_Lname.Name = "textBox_Lname";
            this.textBox_Lname.Size = new System.Drawing.Size(100, 32);
            this.textBox_Lname.TabIndex = 5;
            this.textBox_Lname.TextChanged += new System.EventHandler(this.textBox_Lname_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(283, 456);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "City:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textBox_city
            // 
            this.textBox_city.Location = new System.Drawing.Point(407, 451);
            this.textBox_city.Name = "textBox_city";
            this.textBox_city.Size = new System.Drawing.Size(100, 32);
            this.textBox_city.TabIndex = 7;
            this.textBox_city.TextChanged += new System.EventHandler(this.textBox_city_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(283, 406);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Phone:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_Phone
            // 
            this.textBox_Phone.Location = new System.Drawing.Point(407, 401);
            this.textBox_Phone.Name = "textBox_Phone";
            this.textBox_Phone.Size = new System.Drawing.Size(100, 32);
            this.textBox_Phone.TabIndex = 9;
            this.textBox_Phone.TextChanged += new System.EventHandler(this.textBox_Phone_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(838, 65);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(370, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manage guest";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DataGridView1);
            this.panel2.Location = new System.Drawing.Point(1, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(838, 333);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.ColumnHeadersHeight = 29;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.Location = new System.Drawing.Point(0, 0);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersVisible = false;
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(838, 333);
            this.DataGridView1.TabIndex = 0;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridView1.ThemeStyle.HeaderStyle.Height = 29;
            this.DataGridView1.ThemeStyle.ReadOnly = false;
            this.DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.ThemeStyle.RowsStyle.Height = 24;
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.DataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // GuestForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(838, 627);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox_Phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_city);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Lname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_fname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GuestForm1";
            this.Text = "GuestForm1";
            this.Load += new System.EventHandler(this.GuestForm1_Load);
            this.panel_button.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_fname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Lname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Phone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_clean;
        private Guna.UI2.WinForms.Guna2DataGridView DataGridView1;
    }
}