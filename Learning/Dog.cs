using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class Dog
    {
        public string Name;

        public float Height;

        public float Weight;

        public string Food;


        public Dog(string name, float height, float weight, string food)
        {
            Name = name;
            Height = height;
            Weight = weight;
            Food = food;
        }
        public Dog() { }

        public void Size()
        {
            Console.WriteLine("Height: " + Height + "; Weight:" + Weight);
        }

        public void Eat()
        {
            Console.WriteLine(Name + " eats " + Food);
        }

        public void Play()
        {
            Console.WriteLine(Name + " plays " + "bol");
        }
        public void ChangeName(string newName)
        {
            Name = newName;
        }
        public void ChangeHeight(float newHeight)
        {
            Height = newHeight;
        }

        public string GetValues()
        {
            return Name + " " + Height + " " + Weight + " " + Food;
        }
        
    }
 }
