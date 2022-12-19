using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2;
            Console.WriteLine("Get All Perfect In Range of Between two Number");
            Console.Write("Enter  Number1 : ");
            Number1 = int.Parse(Console.ReadLine());
            Console.Write("Enter  Number2 : ");
            Number2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Below are the perfect number between " + Number1 + " and " + Number2);

            for (int i = Number1; i <= Number2; i++)
            {
                decimal sum = 0;
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                        sum = sum + j;
                }
                if (sum == i)
                    Console.WriteLine("\t" + i);
            }

            Console.ReadKey();
        }
    }
}
