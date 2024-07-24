using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learning
{
    public partial class Form1 : Form
    {
        public Dog[] Dogs = new Dog[2];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOp_Click(object sender, EventArgs e)
        {
            int x = 5;
            float y = 2.6f;
            string z = "hi";
            Console.WriteLine((x + x).GetType());
            Console.WriteLine((x + y).GetType());
            Console.WriteLine((x + z).GetType());
            Console.WriteLine((y + y).GetType());
            Console.WriteLine((y + x).GetType());
            Console.WriteLine((y + z).GetType());
            Console.WriteLine((z + z).GetType());
            Console.WriteLine((z + y).GetType());
            Console.WriteLine((z + x).GetType());
            Console.WriteLine(z + x + y);
            Console.WriteLine(x + y + z);
            Console.WriteLine(y + x + z);
            Console.WriteLine(x + z + y);

            char d = 'x';
            int h = d;

            Console.WriteLine(d);
            Console.WriteLine(h);
            Console.WriteLine(d + h);

        }

        private void btnDod_Click(object sender, EventArgs e)
        {

            Dog dog1 = new Dog();
            Dog dog2 = new Dog("Peter", 0.8f, 15, "Tryfe");
            dog1.Name = "Tofy";
            dog1.Height = 1.0f;


            //Console.WriteLine(dog1.Name);
            //Console.WriteLine(dog1.Height);
            //Console.WriteLine(dog2);
            //Console.WriteLine(dog2.Height);

            //dog1.Size();
            //dog2.Size();
            //dog1.Eat();
            //dog2.Eat();
            //dog1.Play();
            //dog2.Play();

            dog1.ChangeHeight(0.9f);
            Console.WriteLine(dog1.Height);

            Dogs[0] = dog1;

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Dog dog in Dogs)
            {
                if(dog != null)
                {
                    Console.WriteLine(dog.GetValues());
                }
                else
                {
                    break;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
