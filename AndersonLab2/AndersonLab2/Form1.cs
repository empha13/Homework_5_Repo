using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AndersonLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* Emily Anderson
         * October 6, 2022
         * This is a program that will calculate multiplications. This will also show a picture of my cat Mya and a description of her as well. */

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }

        
        private void btnPicture_Click(object sender, EventArgs e)
        {
            // Show the Picture
            picMya.Visible = true;
            // Hide the data label that may display on top of the picture
            lblDescription.Visible = false;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            // Hide the picture and data label on top of it.
            picMya.Visible=false;
            lblDescription.Visible=false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            // Blank out the textboxes and the answer label
            txtNumber.Text = "";
            txtMultiplier.Text = "";
            lblOutput.Text = "";
            // Put the cursor on the top textbox
            txtNumber.Focus();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            // Place My topic is [show the topic name label text - do not type the string].
            lblDescription.Text = "My topic is " + lblTopic.Text + "!\n" +
                "This is my cat Mya. She is our oldest cat of 3. Mya is 3 years old now and she has the attitude of the oldest sibling.\n" +
                "She is very bossy, loves her personal space and believes she is the favourite child.\n" +
                "I love all my cats very much.";

            picMya.Hide();
            lblDescription.Show();

        }

        private void picMya_Click(object sender, EventArgs e)
        {
            // Display a messagebox that tells information about the picture. Place name in the title of the messagebox.
            MessageBox.Show("My Cat Mya", "Emily");
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Assume user has entered valid integers in textboxes.
            // Create three local integer variable: number, multiplier, answer.
            // Place the data from textboxes into the variables (conversion required).
            int Number = Convert.ToInt32(txtNumber.Text);
            int Multiplier = Convert.ToInt32(txtMultiplier.Text);
            int Answer = Number * Multiplier;
            // Multiply the number and multiplier together and place the answer into the variable answer.
            lblOutput.Text = Answer.ToString();
            // Display the answer in the label (conversion required).
        }

    }
}
