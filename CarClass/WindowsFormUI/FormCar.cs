/**
* 25082021
* CSC 253
* Rebecca Garcia
* Car Class Assignment
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

namespace WindowsFormUI
{
    public partial class FormCar : Form
    {
        public FormCar()
        {
            InitializeComponent();
        }

        Car car;

        // could I have placed this in a better location?
        private decimal Speed = 0.0m;
        private decimal Accel = 5m;
        private decimal Brake = -5.0m;


        // displays car info in textBox
        private void addCarButton_Click(object sender, EventArgs e)
        {
            string name = txtYear.Text;
            string make = txtMake.Text;

            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(make)
                && decimal.TryParse(txtSpeed.Text, out Speed))
            {
                car = new Car(name, make, Speed);
            }
            else
                MessageBox.Show("Please correct your input", "Invalid Input");

            try
            {
                carBox.Items.Add("Car Year: " + car.Name);
                carBox.Items.Add("Car Make: " + car.Make);
                carBox.Items.Add("Car Speed: " + car.Speed);
                carBox.Items.Add("-------------------------------------");
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Submit car info first!", "Invalid Input");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // adds 5 to speed
        private void accelerateButton_Click(object sender, EventArgs e)
        {

            Speed = Speed + Accel;

            txtSpeed.Text = Speed.ToString();
        }


        // minus 5 to speed
        private void brakeButton_Click(object sender, EventArgs e)
        {
            Speed = Speed + Brake;

            txtSpeed.Text = Speed.ToString();
        }


        // clears text and labels for new car entry to be stored in textBox
        private void newCarButton_Click(object sender, EventArgs e)
        {
            Speed = 0.0m;
            txtYear.Text = " ";
            txtMake.Text = " ";
            txtSpeed.Text = "0.0";
        }


        // clears form **(but when I clicked add car right after, the previous input shows up, how would I fix that?)
        private void clearButton_Click(object sender, EventArgs e)
        {
            Speed = 0.0m; 
            txtYear.Text = " ";
            txtMake.Text = " ";
            txtSpeed.Text = "0.0";
            carBox.Items.Clear();
        }
    }
}
