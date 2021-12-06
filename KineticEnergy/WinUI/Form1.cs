/**
* 22082021
* CSC 253
* Rebecca Garcia
* Kinetic Energy
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

namespace WinUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Method that accepts mass and velocity
        //as arguments and returns kinetic energy
        private double KineticEnergy(double mass, double velocity)
        {
            return 0.5 * mass * Math.Pow(velocity, 2.0);
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double mass, velocity, energy;

            //retrieves mass input
            if (double.TryParse(massTextBox.Text, out mass))
            {
                //retrieves velocity input
                if (double.TryParse(velocityTextBox.Text, out velocity))
                {
                    //get kinetic energy
                    energy = KineticEnergy(mass, velocity);

                    //display kinetic energy
                    kineticEnergyLabel.Text = energy.ToString("n1");
                }
                else
                {
                    MessageBox.Show("Velocity is invalid.");
                }
            }
            else
            {
                MessageBox.Show("Mass is invalid.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
