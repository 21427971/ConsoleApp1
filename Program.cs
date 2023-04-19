using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 //Msimango KSI
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Msimango KSI
            // Application to check the big number, using a conditional statement
            Console.WriteLine("Enter two numbers");
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int  Num=0;
            if (Num2 > Num1)
            {
                Num = Num2;
                Console.WriteLine("The bigger number is :{0}", Num);
            }
            else
            if (Num2 < Num1)
            {
                Num = Num1;
                Console.WriteLine("The bigger number is :{0}", Num);
            }
            else
                if (Num1 == Num2)
            {
                Console.WriteLine("This numbers are equal");
            }
            else
            {  
             Console.WriteLine("This numbers are invalid");
            }
            //check if the bigger number is an even or odd number
            if (Num%2==0)
            {
                Console.WriteLine("This number is an even number");
            }
            else
            {
                Console.WriteLine("This number is an odd number");
            }
        }
    }
}
