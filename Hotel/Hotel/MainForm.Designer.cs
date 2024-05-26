namespace Hotel
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
            this.button_logout = new System.Windows.Forms.Button();
            this.button_room = new System.Windows.Forms.Button();
            this.button_reception = new System.Windows.Forms.Button();
            this.button_guest = new System.Windows.Forms.Button();
            this.button_dashbord = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.panel_slide2 = new System.Windows.Forms.Panel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_cover = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel_cover.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_logout);
            this.panel1.Controls.Add(this.button_room);
            this.panel1.Controls.Add(this.button_reception);
            this.panel1.Controls.Add(this.button_guest);
            this.panel1.Controls.Add(this.button_dashbord);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(60, 678);
            this.panel1.TabIndex = 0;
            // 
            // button_logout
            // 
            this.button_logout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_logout.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_logout.Image = global::Hotel.Properties.Resources._return;
            this.button_logout.Location = new System.Drawing.Point(0, 618);
            this.button_logout.Name = "button_logout";
            this.button_logout.Size = new System.Drawing.Size(60, 60);
            this.button_logout.TabIndex = 11;
            this.button_logout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_logout.UseVisualStyleBackColor = true;
            this.button_logout.Click += new System.EventHandler(this.button_logout_Click);
            // 
            // button_room
            // 
            this.button_room.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_room.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_room.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_room.Image = global::Hotel.Properties.Resources._286;
            this.button_room.Location = new System.Drawing.Point(0, 241);
            this.button_room.Name = "button_room";
            this.button_room.Size = new System.Drawing.Size(60, 60);
            this.button_room.TabIndex = 5;
            this.button_room.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_room.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_room.UseVisualStyleBackColor = true;
            this.button_room.Click += new System.EventHandler(this.button_room_Click);
            // 
            // button_reception
            // 
            this.button_reception.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_reception.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_reception.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_reception.Image = global::Hotel.Properties.Resources.front_desk;
            this.button_reception.Location = new System.Drawing.Point(0, 181);
            this.button_reception.Name = "button_reception";
            this.button_reception.Size = new System.Drawing.Size(60, 60);
            this.button_reception.TabIndex = 4;
            this.button_reception.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_reception.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_reception.UseVisualStyleBackColor = true;
            this.button_reception.Click += new System.EventHandler(this.button_reception_Click);
            // 
            // button_guest
            // 
            this.button_guest.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_guest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_guest.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_guest.Image = global::Hotel.Properties.Resources.guest;
            this.button_guest.Location = new System.Drawing.Point(0, 121);
            this.button_guest.Name = "button_guest";
            this.button_guest.Size = new System.Drawing.Size(60, 60);
            this.button_guest.TabIndex = 3;
            this.button_guest.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_guest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_guest.UseVisualStyleBackColor = true;
            this.button_guest.Click += new System.EventHandler(this.button_guest_Click);
            // 
            // button_dashbord
            // 
            this.button_dashbord.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_dashbord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dashbord.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dashbord.Image = global::Hotel.Properties.Resources.testhome;
            this.button_dashbord.Location = new System.Drawing.Point(0, 61);
            this.button_dashbord.Name = "button_dashbord";
            this.button_dashbord.Size = new System.Drawing.Size(60, 60);
            this.button_dashbord.TabIndex = 2;
            this.button_dashbord.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button_dashbord.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_dashbord.UseVisualStyleBackColor = true;
            this.button_dashbord.Click += new System.EventHandler(this.button_dashbord_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(60, 61);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Hotel.Properties.Resources._7faf09dc_b643_4912_ba83_f457cf1ece4d;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hotel Management System";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(99, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 37);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tasks";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(97, 603);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(173, 27);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "To clean room";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(97, 636);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(207, 27);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Surver your guests";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(310, 603);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(299, 27);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "Empower Hotel employees";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(310, 636);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(351, 27);
            this.checkBox4.TabIndex = 8;
            this.checkBox4.Text = "Get creative with lost and found";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(659, 603);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(259, 27);
            this.checkBox5.TabIndex = 9;
            this.checkBox5.Text = "Have a sense of humor";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // panel_slide2
            // 
            this.panel_slide2.BackColor = System.Drawing.Color.DimGray;
            this.panel_slide2.ForeColor = System.Drawing.Color.IndianRed;
            this.panel_slide2.Location = new System.Drawing.Point(1, 98);
            this.panel_slide2.Name = "panel_slide2";
            this.panel_slide2.Size = new System.Drawing.Size(16, 105);
            this.panel_slide2.TabIndex = 10;
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.pictureBox2);
            this.panel_main.Controls.Add(this.checkBox5);
            this.panel_main.Controls.Add(this.label1);
            this.panel_main.Controls.Add(this.checkBox4);
            this.panel_main.Controls.Add(this.label3);
            this.panel_main.Controls.Add(this.checkBox3);
            this.panel_main.Controls.Add(this.checkBox1);
            this.panel_main.Controls.Add(this.checkBox2);
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 0);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1041, 678);
            this.panel_main.TabIndex = 11;
            this.panel_main.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(95, 98);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(853, 447);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel_slide2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(60, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 678);
            this.panel4.TabIndex = 12;
            // 
            // panel_cover
            // 
            this.panel_cover.Controls.Add(this.panel_main);
            this.panel_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_cover.Location = new System.Drawing.Point(65, 0);
            this.panel_cover.Name = "panel_cover";
            this.panel_cover.Size = new System.Drawing.Size(1041, 678);
            this.panel_cover.TabIndex = 13;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1106, 678);
            this.Controls.Add(this.panel_cover);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel_cover.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_dashbord;
        private System.Windows.Forms.Button button_room;
        private System.Windows.Forms.Button button_reception;
        private System.Windows.Forms.Button button_guest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Panel panel_slide2;
        private System.Windows.Forms.Button button_logout;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_cover;
    }
}