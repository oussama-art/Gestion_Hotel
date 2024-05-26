namespace Hotel
{
    partial class RoomForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_roPhone = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_button = new System.Windows.Forms.Panel();
            this.comboBox_room = new System.Windows.Forms.ComboBox();
            this.radioButton_free = new System.Windows.Forms.RadioButton();
            this.radioButton_busy = new System.Windows.Forms.RadioButton();
            this.dataGridView_room = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel_button.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).BeginInit();
            this.SuspendLayout();
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
            this.label6.Location = new System.Drawing.Point(381, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(183, 37);
            this.label6.TabIndex = 2;
            this.label6.Text = "Manage Room";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(834, 63);
            this.panel1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(374, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 27);
            this.label5.TabIndex = 23;
            this.label5.Text = "Status:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 27);
            this.label3.TabIndex = 19;
            this.label3.Text = "Phone :";
            // 
            // textBox_roPhone
            // 
            this.textBox_roPhone.Location = new System.Drawing.Point(165, 484);
            this.textBox_roPhone.Name = "textBox_roPhone";
            this.textBox_roPhone.Size = new System.Drawing.Size(159, 36);
            this.textBox_roPhone.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 27);
            this.label2.TabIndex = 17;
            this.label2.Text = "Room Type:";
            // 
            // panel_button
            // 
            this.panel_button.BackColor = System.Drawing.Color.White;
            this.panel_button.Controls.Add(this.button_clean);
            this.panel_button.Controls.Add(this.button_delete);
            this.panel_button.Controls.Add(this.button_update);
            this.panel_button.Controls.Add(this.button_save);
            this.panel_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_button.Location = new System.Drawing.Point(0, 553);
            this.panel_button.Name = "panel_button";
            this.panel_button.Size = new System.Drawing.Size(834, 100);
            this.panel_button.TabIndex = 13;
            // 
            // comboBox_room
            // 
            this.comboBox_room.FormattingEnabled = true;
            this.comboBox_room.Location = new System.Drawing.Point(165, 433);
            this.comboBox_room.Name = "comboBox_room";
            this.comboBox_room.Size = new System.Drawing.Size(159, 35);
            this.comboBox_room.TabIndex = 25;
            // 
            // radioButton_free
            // 
            this.radioButton_free.AutoSize = true;
            this.radioButton_free.Location = new System.Drawing.Point(459, 400);
            this.radioButton_free.Name = "radioButton_free";
            this.radioButton_free.Size = new System.Drawing.Size(81, 31);
            this.radioButton_free.TabIndex = 0;
            this.radioButton_free.TabStop = true;
            this.radioButton_free.Text = "Free";
            this.radioButton_free.UseVisualStyleBackColor = true;
            // 
            // radioButton_busy
            // 
            this.radioButton_busy.AutoSize = true;
            this.radioButton_busy.Location = new System.Drawing.Point(541, 398);
            this.radioButton_busy.Name = "radioButton_busy";
            this.radioButton_busy.Size = new System.Drawing.Size(83, 31);
            this.radioButton_busy.TabIndex = 1;
            this.radioButton_busy.TabStop = true;
            this.radioButton_busy.Text = "Busy";
            this.radioButton_busy.UseVisualStyleBackColor = true;
            // 
            // dataGridView_room
            // 
            this.dataGridView_room.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_room.Location = new System.Drawing.Point(0, 62);
            this.dataGridView_room.Name = "dataGridView_room";
            this.dataGridView_room.RowHeadersWidth = 51;
            this.dataGridView_room.RowTemplate.Height = 24;
            this.dataGridView_room.Size = new System.Drawing.Size(834, 317);
            this.dataGridView_room.TabIndex = 26;
            this.dataGridView_room.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_room_CellClick);
            this.dataGridView_room.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_room_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 27);
            this.label4.TabIndex = 28;
            this.label4.Text = "ID :";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(165, 385);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(159, 36);
            this.textBox_id.TabIndex = 27;
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
            // RoomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 653);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.dataGridView_room);
            this.Controls.Add(this.radioButton_busy);
            this.Controls.Add(this.radioButton_free);
            this.Controls.Add(this.comboBox_room);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_roPhone);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel_button);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RoomForm";
            this.Text = "RoomForm";
            this.Load += new System.EventHandler(this.RoomForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel_button.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_room)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_roPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Panel panel_button;
        private System.Windows.Forms.ComboBox comboBox_room;
        private System.Windows.Forms.RadioButton radioButton_free;
        private System.Windows.Forms.RadioButton radioButton_busy;
        private System.Windows.Forms.DataGridView dataGridView_room;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_id;
    }
}