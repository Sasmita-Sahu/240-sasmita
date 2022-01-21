using System;

namespace ConsoleApp7
{
    class Program
    {
      //  static void Main(string[] args)
      //  {
            
       // }
   }
    abstract class AbsClass
    {
        public int AddTwoNumbers(int Num1, int Num2)
        {
            return Num1 + Num2;
        }
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }
   
    class AbsDerived : AbsClass
    {
        static void Main(string[] args)
        {
            AbsDerived calculate = new AbsDerived();
            int added = calculate.AddTwoNumbers(10, 20);
            int multiplied = calculate.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("added :{0}, multiplied : {1}", added, multiplied);
        }
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;
        }
        
    }

}
