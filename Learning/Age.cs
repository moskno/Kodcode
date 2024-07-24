using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Person
    {
        private int age;

        public int Age { 
            get { return age; }
            set
            {
                if (value < 0 || value > 120)
                {
                    Console.WriteLine("Age must be between 0 and 120." + value);
                }
                else
                {
                    age = value;
                }
            }
        }

        public void printArray()
        {
            int[] steps = { 1, 2, 3, 5, 9, 10 };

            Array.Sort(steps);

            Array.Find(steps, step => step == 3);
        }

    }
}
