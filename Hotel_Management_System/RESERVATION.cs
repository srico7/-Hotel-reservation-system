using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
    internal class RESERVATION
    {
        CONNECT conn = new CONNECT();

        //get all reservations
        public DataTable getAllReserve()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `reservations`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //function to add new reservation

        public bool addReservation(int number, int clientId, DateTime DateIn, DateTime DateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `reservations`(`roomNumber`, `clientId`, `DateIn`, `DateOut`) VALUES (@rnm,@cid,@din@dout)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @rnm,@cid,@din@dout
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.VarChar).Value = DateIn;
            command.Parameters.Add("@dout", MySqlDbType.VarChar).Value = DateOut;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }

            else
            {
                conn.closeConnection();
                return false;
            }
        }

        //function to edit the selected reservation

        public bool editReserve(int reserveId, int number, int clientId, DateTime DateIn, DateTime DateOut)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `reservations` SET `roomNumber`=@rnm,`clientId`=@cid,`DateIn`=@din,`DateOut`=@dout WHERE `reserveId`=@rvid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @rnm,@cid,@din,@dout,@rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = reserveId;
            command.Parameters.Add("@rnm", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = clientId;
            command.Parameters.Add("@din", MySqlDbType.VarChar).Value = DateIn;
            command.Parameters.Add("@dout", MySqlDbType.VarChar).Value = DateOut;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }

            else
            {
                conn.closeConnection();
                return false;
            }
        }

        //function to remove a reservation

        public bool removeReserve(int rsv_id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `reservations` WHERE `reserveId`=@rvid";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            //@rvid
            command.Parameters.Add("@rvid", MySqlDbType.Int32).Value = rsv_id;

            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }
}
