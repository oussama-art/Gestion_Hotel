using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
     class RoomClass
    {
        DB_Connection conn = new DB_Connection();
        //fucntion of list of room's type
        public DataTable getRoomType()
        {
            String selectquery = "SELECT * FROM `category`";
            MySqlCommand command = new MySqlCommand(selectquery, conn.GetConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }


        //fucntion to add new room
        public bool AddRooms(string id,int type ,string phone, string status )
        {
            

            string insertQuerry = "INSERT INTO `room`(`id`, `type`, `phone`, `Status`)" +
                " VALUES (@id,@type,@phone,@status)";
            MySqlCommand command = new MySqlCommand(insertQuerry, conn.GetConnection());
            //@no,@type,@ph,@sts
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@type", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;

            conn.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseCon();
                return true;
            }
            else
            {
                conn.CloseCon();
                return false;
            }
        }
        //fucntion to ger a table of room 
        public DataTable getRoomList()
        {
            String selectquery = "SELECT * FROM `room`";
            MySqlCommand command = new MySqlCommand(selectquery, conn.GetConnection());
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }

        public bool UpdateRooms(string id,int type, string phone, string status)
        {
            string editquery = "UPDATE `room` SET  `phone`= @phone ,`type`= @type ,`Status`= @status  WHERE `id`= @id";
            MySqlCommand command = new MySqlCommand(editquery, conn.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
            conn.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseCon();
                return true;
            }
            else
            {
                conn.CloseCon();
                return false;
            }
        }
        public bool DeleteRoom(string phone)
        {
            string insertquery = "DELETE FROM `room` WHERE `phone`=@phone";
            MySqlCommand command = new MySqlCommand(insertquery, conn.GetConnection());
            command.Parameters.Add("@phone", MySqlDbType.VarChar).Value = phone;

            conn.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                conn.CloseCon();
                return true;
            }
            else
            {
                conn.CloseCon();
                return false;
            }
        }

    }
}
