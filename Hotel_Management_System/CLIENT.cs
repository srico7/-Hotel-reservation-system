using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace Hotel_Management_System
{
    internal class CLIENT
    {
        CONNECT conn = new CONNECT();

        //new client function
        public bool insertClient(String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `client`(`first_name`, `last_name`, `phone`, `country`) VALUES (@fnm,@lnm,@phn,@cnt)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

           // @fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

            conn.openConnection();

             if(command.ExecuteNonQuery() == 1)
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

        // Function to get client list
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `client`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //Function to edit data

        public bool editClient(int id, String fname, String lname, String phone, String country)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `client` SET `first_name`=@fnm,`last_name`=@lnm,`phone`=@phn,`country`=@cnt WHERE `id`=@cid";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @cid,@fnm,@lnm,@phn,@cnt
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@cnt", MySqlDbType.VarChar).Value = country;

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

        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `client` WHERE `id` =@cid";
            command.CommandText= removeQuery;
            command.Connection= conn.getConnection();

            //@cid
            command.Parameters.Add("@cid", MySqlDbType.Int32).Value = id;

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
