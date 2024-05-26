using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel
{
    /* add new guest
        update new guest
    delete guest    

        */
     class GuestClass
    {
        //create fucntion to insert a new guest 
        DB_Connection conn = new DB_Connection();   
        public bool insertGuest(string id,string fname,string lname,string pho,string city) 
        {
            string insertquery = "INSERT INTO `guest`(`GuestId`, `First_name`, `Last_name`, `phone`, `city`) " +
                "VALUES (@id,@fname,@lname,@ph,@city)";
            MySqlCommand command = new MySqlCommand(insertquery, conn.GetConnection());
            command.Parameters.Add("@id",MySqlDbType.VarChar).Value=id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = pho;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
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
        public DataTable getGuest()
        {
            String selectquery = "SELECT * FROM `guest`";
            MySqlCommand command = new MySqlCommand (selectquery, conn.GetConnection());
            DataTable table =  new DataTable() ;
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;

        }
        public bool editGuest(string id, string fname, string lname, string pho, string city)
        {
            string editquery = "UPDATE `guest` SET `First_name`=@fname,`Last_name`=@lname,`phone`=@ph,`city`=@city WHERE `GuestId`=@id";


            MySqlCommand command = new MySqlCommand(editquery, conn.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = pho;
            command.Parameters.Add("@city", MySqlDbType.VarChar).Value = city;
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


        //function to delete data 

        public bool DeleteGuest(string id)
        {
            string insertquery = "DELETE FROM `guest` WHERE `GuestId`=@id";
            string insertquery2 = "DELETE FROM `reservation` WHERE `GuestId`=@id";
            MySqlCommand command = new MySqlCommand(insertquery, conn.GetConnection());
            MySqlCommand command2 = new MySqlCommand(insertquery2, conn.GetConnection());
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            
            conn.OpenCon();
            if (command.ExecuteNonQuery() == 1 || command2.ExecuteNonQuery() == 1)
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
