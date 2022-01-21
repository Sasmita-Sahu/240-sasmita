using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }
    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("dog constructor");
        }
        public override void Sing()
        {
             Console.WriteLine("Animal song");
        }
    };
    
}
