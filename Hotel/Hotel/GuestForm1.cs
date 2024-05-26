using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hotel
{
    public partial class GuestForm1 : Form
    {
        GuestClass guest = new GuestClass();
        public GuestForm1()
        {
            InitializeComponent();
        }

        

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            textBox_fname.Clear();
            textBox_Lname.Clear();
            textBox_Phone.Clear();
            textBox_city.Clear();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if(textBox_id.Text==""||textBox_fname.Text==""|| textBox_Lname.Text==""||textBox_city.Text==""
                || textBox_Phone.Text == "")
            {
                MessageBox.Show("Enter all the fields please !","",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else { 
            try
            {
                string id = textBox_id.Text;    
                string fname = textBox_fname.Text;  
                string lname = textBox_Lname.Text;
                string phone = textBox_Phone.Text;
                string city = textBox_city.Text;

                Boolean insertGuest = guest.insertGuest(id, fname, lname, phone, city);
                if(insertGuest )
                {
                    MessageBox.Show("New guest saved successufuly","Guest Saved",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button_clean.PerformClick();
                    }else
                {
                    MessageBox.Show("Guest not inserted ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
                }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GuestForm1_Load(object sender, EventArgs e)
        {
            DataGridView1.DataSource = guest.getGuest();
            getTable();
            
        }
        private void getTable()
        {
            DataGridView1.DataSource = guest.getGuest();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" || textBox_fname.Text == "" || textBox_Lname.Text == "" || textBox_city.Text == ""
                || textBox_Phone.Text == "")
            {
                MessageBox.Show("Enter all the fields please !", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string id = textBox_id.Text;
                    string fname = textBox_fname.Text;
                    string lname = textBox_Lname.Text;
                    string phone = textBox_Phone.Text;
                    string city = textBox_city.Text;
                    Boolean editGuest = guest.editGuest(id, fname, lname, phone, city);
                    if (editGuest)
                    {
                        MessageBox.Show("guest data updated successufuly", "Update Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Guest data not updated ", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = DataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_fname.Text = DataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_Lname.Text = DataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_Phone.Text = DataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_city.Text = DataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_id.Text == "" )
            {
                MessageBox.Show("Required Field Id", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }else
            {
                try
                {
                    String id = textBox_id.Text;
                    Boolean deleteGuest = guest.DeleteGuest(id);
                    if (deleteGuest)
                    {
                        MessageBox.Show("guest data and reservation deleted successufuly", "Guest Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getTable();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Guest data not deleted ", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void textBox_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Lname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox_city_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox_Phone_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel_button_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_logout_Click(object sender, EventArgs e)
        {

        }
    }
}
