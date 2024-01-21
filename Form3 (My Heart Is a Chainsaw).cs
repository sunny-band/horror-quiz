using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Horror_Quiz
{
    public partial class Form3 : Form
    {

        private SoundPlayer soundPlayer;

        public Form3()
        {
            InitializeComponent();

            this.BackgroundImage = null;
            soundPlayer = new SoundPlayer(Properties.Resources.Demon_Laugh);
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
            if (radioButton4.Checked == true)
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

                this.BackgroundImage = null;

                Program.firstAnsCorrect = true;
                Program.incorrectCount = 0;


            }
            else if((radioButton1.Checked == true) || (radioButton2.Checked == true) || (radioButton3.Checked == true))
            {
                Program.firstAnsCorrect = false;
                Program.incorrectCount++;

                string title;
                string message;

                if (Program.incorrectCount == 1)
                {
                    soundPlayer.Play();
                    this.BackgroundImage = Properties.Resources._487351;

                    label1.BackColor = Color.Transparent;
                    label1.ForeColor = System.Drawing.Color.White;

                    title = "Incorrect";
                    message = "Wrong! Try again.";

                    var result1 = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    title = "Incorrect";
                    message = "Wrong! Try again.";

                    var result2 = MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
             
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form4 = new Form4();
            form4.Closed += (s, args) => this.Close();
            form4.Show();
        }
    }
}
