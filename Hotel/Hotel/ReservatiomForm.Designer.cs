namespace Hotel
{
    partial class ReservatiomForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.dateTimePicker_dateOut = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_dateIn = new System.Windows.Forms.DateTimePicker();
            this.comboBox_roomNo = new System.Windows.Forms.ComboBox();
            this.comboBox_roomType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_guestId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_reservId = new System.Windows.Forms.TextBox();
            this.dataGridView_reserv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(835, 63);
            this.panel1.TabIndex = 36;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(0, 62);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(831, 333);
            this.panel2.TabIndex = 25;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(447, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 27);
            this.label7.TabIndex = 4;
            this.label7.Text = "X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(292, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(255, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manage Reservation";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.White;
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 631);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(835, 100);
            this.panel_button.TabIndex = 31;
            // 
            // dateTimePicker_dateOut
            // 
            this.dateTimePicker_dateOut.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker_dateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateOut.Location = new System.Drawing.Point(545, 427);
            this.dateTimePicker_dateOut.Name = "dateTimePicker_dateOut";
            this.dateTimePicker_dateOut.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_dateOut.TabIndex = 49;
            // 
            // dateTimePicker_dateIn
            // 
            this.dateTimePicker_dateIn.CustomFormat = "dd/MM/yyy";
            this.dateTimePicker_dateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_dateIn.Location = new System.Drawing.Point(545, 383);
            this.dateTimePicker_dateIn.Name = "dateTimePicker_dateIn";
            this.dateTimePicker_dateIn.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker_dateIn.TabIndex = 50;
            // 
            // comboBox_roomNo
            // 
            this.comboBox_roomNo.FormattingEnabled = true;
            this.comboBox_roomNo.Location = new System.Drawing.Point(156, 515);
            this.comboBox_roomNo.Name = "comboBox_roomNo";
            this.comboBox_roomNo.Size = new System.Drawing.Size(141, 31);
            this.comboBox_roomNo.TabIndex = 47;
            // 
            // comboBox_roomType
            // 
            this.comboBox_roomType.FormattingEnabled = true;
            this.comboBox_roomType.Location = new System.Drawing.Point(156, 473);
            this.comboBox_roomType.Name = "comboBox_roomType";
            this.comboBox_roomType.Size = new System.Drawing.Size(141, 31);
            this.comboBox_roomType.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 430);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "Date Out:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(455, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 23);
            this.label4.TabIndex = 45;
            this.label4.Text = "Date In:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 518);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 23);
            this.label2.TabIndex = 43;
            this.label2.Text = "Room No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 44;
            this.label3.Text = "Room Type:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(54, 430);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 23);
            this.label8.TabIndex = 42;
            this.label8.Text = "Guest Id:";
            // 
            // textBox_guestId
            // 
            this.textBox_guestId.Location = new System.Drawing.Point(156, 427);
            this.textBox_guestId.Name = "textBox_guestId";
            this.textBox_guestId.Size = new System.Drawing.Size(141, 32);
            this.textBox_guestId.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 386);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 23);
            this.label9.TabIndex = 40;
            this.label9.Text = "Reserv Id:";
            // 
            // textBox_reservId
            // 
            this.textBox_reservId.Location = new System.Drawing.Point(156, 383);
            this.textBox_reservId.Name = "textBox_reservId";
            this.textBox_reservId.Size = new System.Drawing.Size(141, 32);
            this.textBox_reservId.TabIndex = 39;
            // 
            // dataGridView_reserv
            // 
            this.dataGridView_reserv.AllowUserToAddRows = false;
            this.dataGridView_reserv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_reserv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_reserv.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_reserv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.Location = new System.Drawing.Point(-4, 62);
            this.dataGridView_reserv.Name = "dataGridView_reserv";
            this.dataGridView_reserv.ReadOnly = true;
            this.dataGridView_reserv.RowHeadersVisible = false;
            this.dataGridView_reserv.RowHeadersWidth = 51;
            this.dataGridView_reserv.RowTemplate.DefaultCellStyle.NullValue = null;
            this.dataGridView_reserv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView_reserv.Size = new System.Drawing.Size(841, 273);
            this.dataGridView_reserv.TabIndex = 51;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridView_reserv.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView_reserv.ThemeStyle.HeaderStyle.Height = 23;
            this.dataGridView_reserv.ThemeStyle.ReadOnly = true;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.dataGridView_reserv.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.Height = 22;
            this.dataGridView_reserv.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dataGridView_reserv.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dataGridView_reserv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_reserv_CellClick);
            this.dataGridView_reserv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_reserv_CellContentClick);
            // 
            // button_clean
            // 
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clean.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clean.Image = global::Hotel.Properties.Resources.clean;
            this.button_clean.Location = new System.Drawing.Point(452, 0);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(158, 99);
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
            this.button_delete.Location = new System.Drawing.Point(293, 0);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(164, 100);
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
            this.button_update.Location = new System.Drawing.Point(151, 0);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(146, 99);
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
            this.button_save.Size = new System.Drawing.Size(153, 99);
            this.button_save.TabIndex = 0;
            this.button_save.Text = "Add";
            this.button_save.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // ReservatiomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(835, 731);
            this.Controls.Add(this.dataGridView_reserv);
            this.Controls.Add(this.dateTimePicker_dateOut);
            this.Controls.Add(this.dateTimePicker_dateIn);
            this.Controls.Add(this.comboBox_roomNo);
            this.Controls.Add(this.comboBox_roomType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_guestId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_reservId);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReservatiomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReservatiomForm";
            this.Load += new System.EventHandler(this.ReservatiomForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_reserv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOut;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateIn;
        private System.Windows.Forms.ComboBox comboBox_roomNo;
        private System.Windows.Forms.ComboBox comboBox_roomType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_guestId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_reservId;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridView_reserv;
    }
}