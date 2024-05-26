﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
     class ReservationClass
    {
        DB_Connection connect = new DB_Connection();

        public DataTable roomByType(int type)
        {
            string selectQuery = "SELECT * FROM `room` WHERE `Status` ='Free'";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }

        // to get room type by room no 
        // room type is int
        public int typeByRoomNo(string rno)
        {
            string selectQuery = "SELECT `type` FROM `room` WHERE `id`=@rno";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return Convert.ToInt32(table.Rows[0][0].ToString());

        }
        //To get Reservation Table
        public DataTable getReserv()
        {
            string selectQuery = "SELECT * FROM `reservation`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
        //Room status is change if room reserve
        public bool setReservRoom(string rno, string sts)
        {
            string updateQuery = "UPDATE `room` SET `Status`=@sts WHERE `id`=@rno";
            MySqlCommand command = new MySqlCommand(updateQuery, connect.GetConnection());

            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rno;
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = sts;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }
        }

        // To create a reservataion add
        public bool addReserv(string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "INSERT INTO `reservation`(`GuestId`, `RoomNo`, `DateIn`, `DateOut`) VALUES (@Gid,@Rno,@Din,@Dout)";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@Gid,@Rno,@Din,@Dout

            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@Rno", MySqlDbType.VarChar).Value = roomNo;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        //to create a function for reserv delete
        public bool removeReserv(int id)
        {
            string insertQuerry = "DELETE FROM `reservation` WHERE `RecervId`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@id
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
        // to create a function for edit reservation
        public bool editReserv(int reserId, string guestId, string roomNo, DateTime dateIn, DateTime dateOut)
        {
            string insertQuerry = "UPDATE `reservation` SET `GuestId`=@Gid,`RoomNo`=@Rno,`DateIn`=@Din,`DateOut`=@Dout WHERE `RecervId`=@rid";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
            //@rid@Gid,@Rno,@Din,@Dout
            command.Parameters.Add("@rid", MySqlDbType.Int32).Value = reserId;
            command.Parameters.Add("@Gid", MySqlDbType.VarChar).Value = guestId;
            command.Parameters.Add("@Rno", MySqlDbType.VarChar).Value = roomNo;
            command.Parameters.Add("@Din", MySqlDbType.Date).Value = dateIn;
            command.Parameters.Add("@Dout", MySqlDbType.Date).Value = dateOut;

            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
    }
}
