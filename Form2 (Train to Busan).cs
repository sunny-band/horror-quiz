using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Horror_Quiz
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Confirm button
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                if (Program.firstAnsCorrect == true)
                {
                    Program.score++;
                }

                panel1.Visible = false;
                label1.Visible = false;

                button1.Enabled = false;
                button2.Enabled = true;


                pictureBox1.Visible = false;
                pictureBox2.Visible = true;

                label2.Visible = true;
                label3.Visible = true;

                Program.firstAnsCorrect = true;


            }
            else if((radioButton2.Checked == true) || (radioButton3.Checked == true) || (radioButton4.Checked == true))
            {
                Program.firstAnsCorrect = false;

                string title = "Incorrect";
                string message = "Wrong! Try again.";

                var result = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form3 = new Form3();
            form3.Closed += (s, args) => this.Close();
            form3.Show();
        }
    }
}
