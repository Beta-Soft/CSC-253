/**
* 25082021
* CSC 253
* Rebecca Garcia
* Car Class Assignment
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormUI
{
    class Car
    {
        public Car(string name, string make, decimal speed)
        {
            Name = name;
            Make = make;
            Speed = speed;
        }

        public string Name { get; set; }
        public string Make { get; set; }
        public decimal Speed { get; set; }

    }
}
