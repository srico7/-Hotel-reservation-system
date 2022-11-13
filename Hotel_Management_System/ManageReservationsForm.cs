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
    public partial class ManageReservationsForm : Form
    {
        public ManageReservationsForm()
        {
            InitializeComponent();
        }

        ROOM room = new ROOM();

        private void ManageReservationsForm_Load(object sender, EventArgs e)
        {
            //display room type
            comboBoxRoomType.DataSource = room.roomTypeList();
            comboBoxRoomType.DisplayMember = "label";
            comboBoxRoomType.ValueMember = "category_id";

        }

        //display correct room number accoring to the type

        int type = Convert.ToInt32(comboBoxRoomNumber.SelectedValue.ToString());

            comboBoxRoomNumber.DataSource = room.roomByType(type);
            comboBoxRoomNumber.DisplayMember = "number";
            coomboBoxRoomNumber.ValueMember = "number";



        private void dateTimePickerIN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_Form mform = new Main_Form();
            mform.Show();
        }

        private void buttonAddReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int clientID = Convert.ToInt32(textBoxClientID.Text);
                int roomNumber = Convert.ToInt32(comboBoxRoomNumber.SelectedValue);
                DateTime dateIn = dateTimePickerIN.Value;
                DateTime dateOut = dateTimePickerOUT.Value;

                // date in must be = or > today date
                // date out must be = or > date in
                if (DateTime.Compare(dateIn.Date, DateTime.Now.Date) < 0)
                {
                    MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (DateTime.Compare(dateOut.Date, dateIn.Date) < 0)
                {
                    MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.addReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        // set the room free column to NO
                        // you can add a message if the room is edited
                        room.setRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.getAllReserv();
                        MessageBox.Show("New Reservation Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonEditReserve_Click(object sender, EventArgs e)
        {
           

                try
                {
                    int rserveID = Convert.ToInt32(textBoxReserveID.Text);
                    int clientID = Convert.ToInt32(textBoxClientID.Text);
                    int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                    DateTime dateIn = dateTimePickerIN.Value;
                    DateTime dateOut = dateTimePickerOUT.Value;

                    // date in must be = or > today date
                    // date out must be = or > date in
                    if (dateIn < DateTime.Now)
                    {
                        MessageBox.Show("The Date In Must Be = or > To Today Date", "Invalid Date In", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else if (dateOut < dateIn)
                    {
                        MessageBox.Show("The Date Out Must Be = or > To Date In", "Invalid Date Out", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        //rservId
                        if (reservation.editReserve(rserveID, roomNumber, clientID, dateIn, dateOut))
                        {
                            // set the room free column to NO
                            // you can add a message if the room is edited
                            room.setRoomFree(roomNumber, "No");
                            dataGridView1.DataSource = reservation.getAllReserv();
                            MessageBox.Show("Reservation Data Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Reservation NOT Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Add Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            
        }

        private void buttonRemoveReserve_Click(object sender, EventArgs e)
        {
            try
            {
                int reserveId = Convert.ToInt32(textBoxReserveID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                if (reservation.removeReserve(reserveId))
                {
                    dataGridView1.DataSource = reservation.getAllReserve();
                    // after deleting a reservation we need to set free column to 'Yes'

                    room.setRoomFree(roomNumber, "Yes");
                    MessageBox.Show("Reservation Deleted", "Delete Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Reservation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxClientID.Text = "";
            textBoxReserveID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            dateTimePickerIN.Value = DateTime.Now;
            dateTimePickerOUT.Value = DateTime.Now;
        }

        private void comboBoxRoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}