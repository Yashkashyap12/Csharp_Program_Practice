using System;

namespace Polymorphism_Override_Program
{
    class Animal  //Base Class (parent)
    {
        public virtual void animalsound()
        {
            Console.WriteLine("The animal makes a sound");
        }
    }

    class Pig : Animal  //Derived Class (child)
    {
        public override void animalsound()
        {
            Console.WriteLine("The Pig says : wee wee");
        }

        class Dog : Animal
        {
            public override void animalsound()
            {
                Console.WriteLine("The Dog says : boww boww");
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Animal animal = new Animal(); //create a animal object 
                Pig mypig = new Pig(); //create a pig object
                Dog mydog = new Dog(); //create a dog object

                animal.animalsound();
                mypig.animalsound();
                mydog.animalsound();

                Console.ReadLine();

            }
        }
    }
}