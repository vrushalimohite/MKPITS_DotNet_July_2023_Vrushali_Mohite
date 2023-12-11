using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_animal_machine_test
{
    class Animal
    {
        string name { get; set; }
        int age { get; set; }
        public Animal(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void makesound()
        {
            Console.WriteLine("Animal sound");
        }
    }
    class Mammal : Animal
    {
        public Mammal(string name, int age) : base(name, age)
        {

        }
        public override void makesound()
        {
            Console.WriteLine("Mamel sound");
        }
        class Reptile : Animal
        {
            public Reptile(string name, int age) : base(name, age)
            {

            }
            public override void makesound()
            {
                Console.WriteLine("Reptile sound");
            }

            class Bird : Animal
            {
                public Bird(string name, int age) : base(name, age)
                {

                }
                public override void makesound()
                {
                    Console.WriteLine("Bird sound");
                }

            }


            internal class Program
            {
                static void Main(string[] args)
                {
                    Animal Mammal = new Mammal( "hj",12);
                    Animal Reptile = new Reptile("hj", 12);
                    Animal Bird = new Bird("hj", 12);
                    Bird.makesound();
                    Reptile.makesound();
                    Mammal.makesound();
                    Console.ReadLine();

                }
            }
        }
    }

}
