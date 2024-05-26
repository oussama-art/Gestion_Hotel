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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        

        private void button_dashbord_Click(object sender, EventArgs e)
        {
            panel_slide2.Height= button_dashbord.Height;
            panel_slide2.Top= button_dashbord.Top;
            panel_cover.Controls.Clear();
            panel_cover.Controls.Add(panel_main);



        }

        private void button_guest_Click(object sender, EventArgs e)
        {
            panel_slide2.Height = button_dashbord.Height;
            panel_slide2.Top = button_guest.Top;
            panel_cover.Controls.Clear();
            GuestForm1 guest = new GuestForm1();
            guest.TopLevel =false;
            guest.Dock = DockStyle.None;   
            guest.FormBorderStyle = FormBorderStyle.None;
            panel_cover.Controls.Add(guest);
            guest.Show();



        }
        

        private void button_reception_Click(object sender, EventArgs e)
        {
            panel_slide2.Height = button_reception.Height;
            panel_slide2.Top = button_reception.Top;


            panel_cover.Controls.Clear();
            ReservatiomForm reservation = new ReservatiomForm();
            reservation.TopLevel = false;
            reservation.Dock = DockStyle.Fill;
            reservation.FormBorderStyle = FormBorderStyle.None;
            panel_cover.Controls.Add(reservation);
            reservation.Show();
        }

        private void button_room_Click(object sender, EventArgs e)
        {
            panel_slide2.Height = button_room.Height;
            panel_slide2.Top = button_room.Top;
            panel_cover.Controls.Clear();
            RoomForm room = new RoomForm();
            room.TopLevel = false;
            room.Dock = DockStyle.None;
            room.FormBorderStyle = FormBorderStyle.None;
            panel_cover.Controls.Add(room);
            room.Show();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            panel_slide2.Height -= button_logout.Height;
            panel_slide2.Top -= button_logout.Top;
            

            LoginFrom login = new LoginFrom();
            this.Hide();
            login.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
