using System;
namespace multiLevel{
    //// this class is a parent Class
    class animal{
        public void Eat()
        {
            Console.WriteLine("The Animals is Eating.");
        }
    }
    /////this is The Child class of the animal and the parent class of puppy
    class dog: animal{
        public void bark(){
            Console.WriteLine("The Dog is Barking.");
        }
    }
    //this is the Child Class of dog
    class puppy: dog{
        public void pupping(){
            Console.WriteLine("The puppy is pupping.");
        }
    }
    class multiLevelInheritance{
        static void Main(string[] args){
            puppy pup = new puppy();
            pup.Eat();
            pup.bark();
            pup.pupping();
        }
    }
}