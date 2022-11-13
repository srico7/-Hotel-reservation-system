﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hotel_Management_System
{
    //class to manage rooms
    internal class ROOM
    {
        CONNECT conn = new CONNECT();

        // function to get room's type
        public DataTable roomTypeList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms_category`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        // function to get room's by type
        public DataTable roomByType(int type)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms` WHERE `type`=@typ", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //function to add new room

        public bool addRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String insertQuery = "INSERT INTO `rooms`(`number`, `type`, `phone`, `free`) VALUES (@num,@typ,@phn,@fr)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            // @num,@typ,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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

        //function to get a list of all rooms

        public DataTable getRooms()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `rooms`", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        //function to edit the selected room

        public bool editRoom(int number, int type, String phone, String free)
        {
            MySqlCommand command = new MySqlCommand();
            String editQuery = "UPDATE `rooms` SET `type`= @typ,`phone`= @phn,`free`= @fr WHERE `number`= @num";
            command.CommandText = editQuery;
            command.Connection = conn.getConnection();

            // @num,@typ,@phn,@fr
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;
            command.Parameters.Add("@typ", MySqlDbType.Int32).Value = type;
            command.Parameters.Add("@phn", MySqlDbType.VarChar).Value = phone;
            command.Parameters.Add("@fr", MySqlDbType.VarChar).Value = free;

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

        //function to remove a room

        public bool removeRoom(int number)
        {
            MySqlCommand command = new MySqlCommand();
            String removeQuery = "DELETE FROM `rooms` WHERE `number` =@num";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();

            //@num
            command.Parameters.Add("@num", MySqlDbType.Int32).Value = number;

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
