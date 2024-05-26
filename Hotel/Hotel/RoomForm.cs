using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    public partial class RoomForm : Form
    {
        RoomClass roomClass = new RoomClass();
        public RoomForm()
        {
            InitializeComponent();
        }

        private void RoomForm_Load(object sender, EventArgs e)
        {
            // room type  f comboBox
            comboBox_room.DataSource = roomClass.getRoomType();
            comboBox_room.DisplayMember = "number";
            comboBox_room.ValueMember = "id";
            //room list
            getRoomList();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Red;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            label7.ForeColor = Color.Black;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            
            string no = textBox_id.Text;
            int type = Convert.ToInt32(comboBox_room.SelectedValue.ToString());
            string ph = textBox_roPhone.Text;
            string status = radioButton_free.Checked ? "Free" : "Busy";
            if(no == "")
            {
                MessageBox.Show("Field Id required", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            try
            {
                if (roomClass.AddRooms(no, type, ph, status))
                {
                    MessageBox.Show("Room Added Successfuly", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            }
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_id.Clear();
            comboBox_room.SelectedIndex = 0;
            textBox_roPhone.Clear();

        }
        private void getRoomList()
        {
            dataGridView_room.DataSource = roomClass.getRoomList();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            string no = textBox_id.Text;
            int type = Convert.ToInt32(comboBox_room.SelectedValue.ToString());
            string ph = textBox_roPhone.Text;
            string status = radioButton_free.Checked ? "Free" : "Busy";

            try
            {
                if (roomClass.UpdateRooms(no, type, ph, status))
                {
                    MessageBox.Show("Room Update Successfuly", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getRoomList();
                    button_clean.PerformClick();
                }
                else
                {
                    MessageBox.Show("Room Not Update", "Update Room", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView_room_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_id.Text = dataGridView_room.CurrentRow.Cells[0].Value.ToString();
            comboBox_room.SelectedValue= dataGridView_room.CurrentRow.Cells[1].Value;
            textBox_roPhone.Text = dataGridView_room.CurrentRow.Cells[2].Value.ToString();
            string rbutton = dataGridView_room.CurrentRow.Cells[3].Value.ToString();
            if (rbutton.Equals("Free"))
            {
                radioButton_free.Checked = true;
            }
            else
            {
                radioButton_busy.Checked = true;
            }

        }

        private void dataGridView_room_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (textBox_roPhone.Text == "")
            {
                MessageBox.Show("Required Field phone", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    string phone = textBox_roPhone.Text;
                    bool deleteRoom = roomClass.DeleteRoom(phone);

                    if (deleteRoom)
                    {
                        MessageBox.Show("Room data deleted successfully", "Room Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getRoomList();
                        button_clean.PerformClick();
                    }
                    else
                    {
                        MessageBox.Show("Room data not deleted", "Error delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
