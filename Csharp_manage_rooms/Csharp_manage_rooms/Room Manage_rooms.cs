using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Csharp_manage_rooms
{
    public partial class Room_Manage_rooms : Form
    {
        public Room_Manage_rooms()
        {
            InitializeComponent();
        }
        Room_Manageform room = new Room_Manageform();
        private void Room_Manageform_load(object sender, EventArgs e)

        { comboBoxRT.DataSource = Room_Manageform.room();
            comboBoxRT.DisplayMember = "label";
            comboBoxRT.ValueMember="category_id";

       
            dataGridView1.DataSource = Room_Manageform.getroom();
        }

        private void button1_Click(object sender, EventArgs e)


        {
            int type = Convert.ToInt32(comboBoxRT.SelectedValue.ToString());
            string phone = textBoxphone.Text;
            string Free = "";

            try
            {
                int number = Convert.ToInt32(textBoxphone.Text);
                if (radioButtonYES.Checked)
                {
                    Free = "Yes";
                    dataGridView1.DataSource = Room_Manageform.getroom();
                    MessageBox.Show("Room added succesfullly","Add room",MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else if (radioButtonNO.Checked)
                {
                    Free = "No";
                    MessageBox.Show("Room not added", "Addd room", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button2Edit_Click(object sender, EventArgs e)
        {
            int number= Convert.ToInt32(textBox1ID.Text);
            int type = Convert.ToInt32(comboBoxRT.SelectedValue.ToString());
            String phone = textBoxphone.Text;
            String free = "";

            try
            {
                int number = Convert.ToInt32(textBox1ID.Text);
                if (radioButtonYES.Checked)
                {
                    free = "Yes";
                }
                else if (radioButtonNO.Checked)
                {
                    free = "No";
                }

                
                else
                {
                    dataGridView1.DataSource = Room_Manageform.getroom();
                    MessageBox.Show("Room Data NOT Updated", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button3Remove_Click(object sender, EventArgs e)
        {
            try
            {
                {
                    int number = Convert.ToInt32(textBox1ID.Text);
                    comboBoxRT.SelectedIndex = 0;
                    textBoxphone.Text = "";
                }
            
               
                else 
                {
                    dataGridView1.DataSource = Room_Manageform.getroom();
                    MessageBox.Show("Room Data NOT Deleted", "Remove Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Room Number Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //display selected row data from datagridview to textboxes
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRT.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value;
            textBoxphone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            String free = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if(free.Equals("YES"))
            {
                radioButton1YES.Checked = true;
            }else if(free.Equals("NO"))
            {
                radioButtonNO.Checked = false;
                   
            }
        }

        private void button4Clear_Click(object sender, EventArgs e)
        {
            textBox1ID.Text = "";
            comboBoxRT.SelectedIndex = 0;
            textBoxphone.Text = "";
            radioButton1YES.Checked = true;

        }
    }
    }
    