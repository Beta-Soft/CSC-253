/**
* 22082021
* CSC 253
* Rebecca Garcia
* Celsius to Fahrenheit
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double celsius, fahrenheit;

            conversionListBox.Items.Add("Celsius\t\tFahrenheit");

            for (celsius = 0; celsius <= 20; celsius++)
            {
                fahrenheit = (9.0 / 5.0) * celsius + 32;
                conversionListBox.Items.Add(celsius + "\t\t" + fahrenheit);           
            }
        }
    }
}
