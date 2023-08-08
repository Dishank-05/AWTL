using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical2_2_Salary
{
    class Salary
    {
        private int basic, ta, da, hra;

        public Salary()
        {
            da = 4000;
            hra = 6000;
        }

        public void GetInfo()
        {
            Console.WriteLine("Please Enter your Basic Salary");
            basic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please Enter Your Travelling Allowance");
            ta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------");
        }

        public void Display()
        {
            Console.WriteLine("\nBasic Salary = " + basic);
            Console.WriteLine("\nTravelling Allowance = " + ta);
            Console.WriteLine("\nHosing Rent Allowance = " + hra);
            Console.WriteLine("\nDearness Allowance = " + da);
            Console.WriteLine("\nGross Salary = " + (basic + ta + hra + da));
        }
    }
        class Program
        {
          static void Main(string[] args) 
          {
            Salary sal = new Salary();
            sal.GetInfo();
            sal.Display();
            
          }
        }

}
