using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/**************************************
 * Name: Reece Sharp
 * Date: 4/30/2022
 * Description: A program using user-created method
 *              for the math function Square and Cube
 * Assistance:
 *************************************/

namespace Exponents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void xGoButton_Click(object sender, EventArgs e)
        {
            // STORAGE
            int num;
            // INPUT
            num = Convert.ToInt32(uxInputTextBox.Text);

            // PROCESS
            /* calculate the square of the number and add it to the output - 
             * do this with a method call that allows you to pass the number
             * and then receive the answer */
            uxOutputLabel.Text = "Square is: " + Square(num).ToString();
            uxOutputLabel.Visible = true;
            /* calculate the cube of the number and add it to the output - 
             * do this by creating a methd as in the squaring example above */
            uxOutputLabel.Text += "\nCube is: " + Cube(num).ToString();
            // OUTPUT
            // set the output to visible

            // turn the Go button off
        }

        public int Square(int num)
        {
            // we will create this code in class
            return num * num;
        }

        public int Cube(int num)
        {
            // we will create this code in class
            return num * num * num;
        }

        private void xResetButton_Click(object sender, EventArgs e)
        {
            // the input and output text should be emptied
            // turn the output to invisible
            // turn the Go button back on
        }

        private void uxInputTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
