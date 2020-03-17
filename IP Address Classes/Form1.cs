using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IP_Address_Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double number = double.Parse(numTextBox.Text); //gets variable
                char ipClass;

                if (number >= 1 && number <= 255)
                {
                    numLabel.Text = number.ToString();
                }
                else
                {
                    MessageBox.Show("Make sure your number is from 1-255.");
                    numTextBox.Text = "";
                }
                //determines class and outputs including mask if necessary
                if (number >= 1 && number <= 126)
                {
                    ipClass = 'A';
                    classLabel.Text = ipClass.ToString();
                    maskLabel.Text = "255.0.0.0";
                }
                else if (number >= 128 && number <= 191)
                {
                    ipClass = 'B';
                    classLabel.Text = ipClass.ToString();
                    maskLabel.Text = "255.255.0.0";
                }
                else if (number >= 192 && number <= 223)
                {
                    ipClass = 'C';
                    classLabel.Text = ipClass.ToString();
                    maskLabel.Text = "255.255.255.0";
                }
                else if (number >= 224 && number <= 239)
                {
                    ipClass = 'D';
                    classLabel.Text = ipClass.ToString();
                }
                else if (number >= 240 && number <= 255)
                {
                    ipClass = 'E';
                    classLabel.Text = ipClass.ToString();
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            numTextBox.Text = "";
            numLabel.Text = "";
            classLabel.Text = "";
            maskLabel.Text = "";
        }
    }
}
