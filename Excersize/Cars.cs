using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excersize
{
    enum color
    {
        Red,
        Green,
        Blue,
    }

    internal class Cars
    {
        public string carColor;

        public Cars(string carColor)
        {
            this.carColor = carColor;
        }   
        public void DisplayColor()
        {
            Console.WriteLine(carColor);
        }
    }


}
