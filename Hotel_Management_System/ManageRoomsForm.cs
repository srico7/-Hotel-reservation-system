using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ManageRoomsForm : Form
    {
        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();
        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

            dataGridView1.DataSource = room.getRooms();

        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string phone = textBoxphone.Text;
            string free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
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
            
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            String phone = textBoxphone.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);
                if (radioButton1YES.Checked)
                {
                    free = "YES";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "NO";
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

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            try
            {
                int number = Convert.ToInt32(textBoxNumber.Text);

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



        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxphone.Text = "";
            radioButton1YES.Checked = true;
        }

        //display selected row data from datagridview to textboxes

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxNumber.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxphone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            string free = dataGridView1.CurrentRow.Cells[3].Value.ToString();

            if (free.Equals("Yes"))
            {
                radioButton1YES.Checked = true;
            }
            else if (free.Equals("No"))
            {
                radioButtonNO.Checked = true;
            }
        }

        private void comboBoxRoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form mform = new Main_Form();
            mform.Show();
        }
    }
}