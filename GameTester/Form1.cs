using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameTester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PictureBox aPictureBox2 = null;
        private void Form1_Load(object sender, EventArgs e)
        {
            // add text to the nonvisible label
            lblForDynamicItems.Text = "These were built during runtime";
            //Make a textbox
            TextBox aTextBox = new TextBox();               // instantiate a textbox
            aTextBox.Multiline = true;                      // allow it to grow
            aTextBox.BackColor = Color.Blue;                // set the background color
            aTextBox.BorderStyle = BorderStyle.FixedSingle; // put a boarder on it
            aTextBox.Size = new Size(100, 100);             // set the size
            aTextBox.Location = new Point(10, 400);         // set the location
            Controls.Add(aTextBox);                         // add it to the form

            // Make a pictureBox
            PictureBox aPictureBox = new PictureBox();      // instantiate a picturebox
            aPictureBox.Size = new Size(100, 100);          // set the size
            aPictureBox.BackColor = Color.Blue;             // set the background color
            aPictureBox.BorderStyle = BorderStyle.FixedSingle; //put a border on it
            aPictureBox.Location = new Point(230, 400);     // set the location
            Controls.Add(aPictureBox);                      // add it to the form


            // Make a Label
            Label aLabel = new Label();                     // instantiate a label
            aLabel.AutoSize = false;                        // turn off autosize for a fixed size
            aLabel.BorderStyle = BorderStyle.FixedSingle;   // put a boarder on it
            aLabel.Size = new Size(100, 100);               // set the size
            aLabel.BackColor = Color.Blue;                  // set the background color
            aLabel.Location = new Point(120, 400);          // set the location
            Controls.Add(aLabel);                           // add it to the form

            // Make a pictureBox#2
            aPictureBox2 = new PictureBox                   // an alternate way to instantiate a Picture box
            {
                Size = new Size(100, 100),
                BackColor = Color.BlueViolet,
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(350, 400)
            };
            Controls.Add(aPictureBox2);
            




        }

        private void btnSetDefault_Click(object sender, EventArgs e)
        {
            aPictureBox2.BackColor = DefaultBackColor;
            
        }
    }
}
