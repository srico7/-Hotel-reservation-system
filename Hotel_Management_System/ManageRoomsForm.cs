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
            int number = Convert.ToInt32(textBoxNumber.Text);
            int type = Convert.ToInt32(comboBoxRoomType.SelectedValue.ToString());
            string phone = textBoxphone.Text;

            if (room.addRoom(number, type, phone, "Yes"))
            {
                MessageBox.Show("Room Added Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Room Not Added ", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxNumber.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxphone.Text = "";
        }
    }
}