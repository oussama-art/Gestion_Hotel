﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hotel
{
    public partial class LoginFrom : Form
    {
        DB_Connection connect = new DB_Connection();
        public LoginFrom()
        {
            InitializeComponent();
        }

        private void label_exit_MouseEnter(object sender, EventArgs e)
        {
            label_exit.ForeColor = Color.Red;
        }

        private void label_exit_MouseLeave(object sender, EventArgs e)
        {
            label_exit.ForeColor= Color.Red;
        }

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginFrom_Load(object sender, EventArgs e)
        {
            //now we need to connect to database 

        }

        private void Button_login_Click(object sender, EventArgs e)
        {
            //if (TextBox_username.Text.Trim().Equals("") || TextBox_password.Text == "")
            //{
            //    MessageBox.Show("Enter your username and password to login", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{

            

            //    DataTable table = new DataTable();
            //    MySqlDataAdapter adapter = new MySqlDataAdapter();
            //    String selectquery = "SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass";
            //    MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
            //    command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;
            //    command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBox_password.Text;
            //    adapter.SelectCommand = command;
            //    adapter.Fill(table);



            //    if (table.Rows.Count > 0)
            //    {
            //        this.Hide();
            //        MainForm mainForm = new MainForm();
            //        mainForm.Show();
            //    }
            //    else
            //    {
                   
            //        MessageBox.Show("your username and password Doesn't exists","Wrong Information",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    
            //    }

            //}

        }

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (TextBox_username.Text.Trim().Equals("") || TextBox_password.Text == "")
            {
                MessageBox.Show("Enter your username and password to login", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                DataTable table = new DataTable();
                MySqlDataAdapter adapter = new MySqlDataAdapter();
                String selectquery = "SELECT * FROM `users` WHERE `username` = @usn AND `password` = @pass";
                MySqlCommand command = new MySqlCommand(selectquery, connect.GetConnection());
                command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBox_username.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBox_password.Text;
                adapter.SelectCommand = command;
                adapter.Fill(table);



                if (table.Rows.Count > 0)
                {
                    this.Hide();
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                }
                else
                {

                    MessageBox.Show("your username and password Doesn't exists", "Wrong Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
