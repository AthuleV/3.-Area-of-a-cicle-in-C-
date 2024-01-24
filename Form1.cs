using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Area_of_a_cicle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the radius from the user input
            if (double.TryParse(textBox1.Text, out double radius) && radius >= 0)
            {
                // Calculate the area of the circle using the formula: A = π * r^2
                double area = Math.PI * Math.Pow(radius, 2);

                // Display the result
                label2.Text = $"Area: {area:F2}";
            }
            else
            {
                // Display an error message if the input is invalid
                MessageBox.Show("Invalid input. Please enter a non-negative number for the radius.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
