using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_manage_rooms
{
    public partial class Room_Manageform : Form
    {
        public Room_Manageform()
        {
            InitializeComponent();
        }
        Room room = new Room();
       
    
        private void load(object sender, EventArgs e)
        {
            comboBoxRT.DataSource = room.roomTypelist();
            comboBoxRT.DisplayMember = "label";
            comboBoxRT.ValueMember = "category_id";

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)

        {

            int type = Convert.ToInt32(comboBoxRT.SelectedValue.ToString());
            string phone = textBox2.Text;
            string free = "";

            try
            {
                int number = Convert.ToInt32(textBox2.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }

                if (room.addRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Not Added", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(comboBoxRT.SelectedValue.ToString());
            String phone = textBox2.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(textBox2.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }

                if (room.editRoom(number, type, phone, free))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveRooom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBox2.Text);

                if (room.removeRoom(number))
                {
                    dataGridView1.DataSource = room.getRooms();
                    MessageBox.Show("Room Data Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
    
}