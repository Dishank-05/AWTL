using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac2_1
{
    class Staff
    {
        public String name, post;
        public void GetData()
        {
            Console.WriteLine("Please Enter Your Name = ");
            name = Console.ReadLine();

            Console.WriteLine("Please Enter Your Post = ");
            post = Console.ReadLine();

            Console.WriteLine("---------------");
        }

        public void Display()
        {
            Console.WriteLine("Name = " + name + "Post = " + post);
        }
          public void Check()
        {
            if (post == "hod" || post =="HOD" )
            {
                Console.WriteLine("Please find the HOD Details");
                Console.WriteLine("Name = " + name + "Post = " + post);
            }
        }
    
    
    }

 class Program
    {
        static void Main(String[] args)
        {
            Staff[] objstaff = new Staff[5];
            
            for (int i = 0; i < 5; i++)
            {
                objstaff[i] = new Staff();
                Console.WriteLine("Staff " + (i + 1) + " Details");
                objstaff[i].GetData();
            }
            Console.WriteLine("Staff Details are");
            for (int i = 0; i < 5; i++) 
            {
                objstaff[i].Display();
            }

            Console.WriteLine("---------------");
            for (int i = 0; i < 5; i++)
            {
                objstaff[i].Check();
            }
            Console.WriteLine("----------------");
        }
    }

}
