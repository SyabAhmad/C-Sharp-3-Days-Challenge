using System;
namespace multiLevel{
    //// this class is a parent Class
    class animal{
        public virtual void Eat()
        {
            Console.WriteLine("The Animals is Eating.");
        }
    }
    /////this is The Child class of the animal and the parent class of puppy
    class dog: animal{
        public override void Eat(){
            Console.WriteLine("The Dog is Barking.");
        }
    }
    class multiLevelInheritance{
        static void Main(string[] args){
            puppy pup = new puppy();
            pup.Eat();
            
        }
    }
}