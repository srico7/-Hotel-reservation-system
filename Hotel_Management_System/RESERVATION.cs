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
    }
}
