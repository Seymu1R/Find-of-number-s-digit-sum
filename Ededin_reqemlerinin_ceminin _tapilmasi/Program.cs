using System;

namespace Ededin_reqemlerinin_ceminin__tapilmasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please,include number ");
            int number = Convert.ToInt32(Console.ReadLine());
            int remainder = 0;
            int total = 0;
            
            while (number>0)
            {
                remainder = number % 10;
                total += remainder;
                number /= 10;
                
            }
            Console.WriteLine("Sum of digits  "+total);

        }
               
              
        

    }
}
