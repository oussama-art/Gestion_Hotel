using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Hotel
{
    public partial class ReservatiomForm : Form
    {
        RoomClass room = new RoomClass();
        ReservationClass reservation = new ReservationClass();
        public ReservatiomForm()
        {
            InitializeComponent();
        }
        private void ReservatiomForm_Load(object sender, EventArgs e)
        {
            //room type f comboBox 
            comboBox_roomType.DataSource = room.getRoomType();
            comboBox_roomType.DisplayMember = "number";
            comboBox_roomType.ValueMember = "id";

            int type = Convert.ToInt32(comboBox_roomType.SelectedValue.ToString());
            comboBox_roomNo.DataSource = reservation.roomByType(type);
            comboBox_roomNo.DisplayMember = "id";
            comboBox_roomNo.ValueMember = "id";

            dataGridView_reserv.DefaultCellStyle.ForeColor = Color.Black;
            // Reservation list f DatagridView
            getReservTable();



        }
        public void getReservTable()
        {
            dataGridView_reserv.DataSource = reservation.getReserv();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                string guestId = textBox_guestId.Text;
                string roomNo = comboBox_roomNo.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_dateIn.Value;
                DateTime dOut = dateTimePicker_dateOut.Value;

               
                if (dIn < DateTime.Today)
                {
                    MessageBox.Show("Reservation Date In must be Today Or After", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dOut < dIn)
                {
                    MessageBox.Show("Reservation Date Out must be same Date In and After", "invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (reservation.addReserv(guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Busy"))
                    {
                        getReservTable();
                        MessageBox.Show("New Reservation add Successfuly", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Reservation Not add Successfuly", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Add Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBox_reservId.Text);
                string guestId = textBox_guestId.Text;
                string roomNo = comboBox_roomNo.SelectedValue.ToString();
                DateTime dIn = dateTimePicker_dateIn.Value;
                DateTime dOut = dateTimePicker_dateOut.Value;
                
                
                if (guestId == "" || roomNo == "" || dIn == dOut)
                {
                    MessageBox.Show("Fields Empty", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    if (dIn < DateTime.Today)
                    {
                        MessageBox.Show("Reservation Date In must be Today Or After", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (dOut < dIn)
                    {
                        MessageBox.Show("Reservation Date Out must be same Date In and After", "invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (reservation.editReserv(reservId, guestId, roomNo, dIn, dOut) && reservation.setReservRoom(roomNo, "Busy"))
                        {
                            getReservTable();
                            MessageBox.Show("Reservation edit Successfuly", "Update Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("Reservation Not edit Successfuly", "Error Update", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Reservation Edit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if(textBox_reservId.Text == "")
            {
                MessageBox.Show("Fields Empty", "Error Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int reserId = Convert.ToInt32(textBox_reservId.Text.ToString());
                string rno = comboBox_roomNo.Text;
                
                    
                    try
                    {
                        if (reservation.removeReserv(reserId) && reservation.setReservRoom(rno, "Free"))
                        {
                            getReservTable();
                            MessageBox.Show("Delete Reservatoin Successfuly", "Deleted Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                
            }
            
            
        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            textBox_reservId.Clear();
            textBox_guestId.Clear();
            comboBox_roomType.SelectedValue = 1;
            dateTimePicker_dateIn.Value = DateTime.Now;
            dateTimePicker_dateOut.Value = DateTime.Now;
            textBox_guestId.ReadOnly = false;
            textBox_guestId.HideSelection = true;
        }

        

        private void label_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void dataGridView_reserv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_reservId.Text = dataGridView_reserv.CurrentRow.Cells[0].Value.ToString();
            textBox_guestId.Text = dataGridView_reserv.CurrentRow.Cells[1].Value.ToString();

            string rno = dataGridView_reserv.CurrentRow.Cells[2].Value.ToString();
            comboBox_roomType.SelectedValue = reservation.typeByRoomNo(rno);
            comboBox_roomNo.Text = rno;
            //comboBox_roomType
            dateTimePicker_dateIn.Text = dataGridView_reserv.CurrentRow.Cells[3].Value.ToString();
            dateTimePicker_dateOut.Text = dataGridView_reserv.CurrentRow.Cells[4].Value.ToString();
            textBox_guestId.ReadOnly = true;
            textBox_guestId.HideSelection = false;
        }

        private void dataGridView_reserv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
