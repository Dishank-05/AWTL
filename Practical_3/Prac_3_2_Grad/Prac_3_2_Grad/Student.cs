using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prac_3_2_Grad
{
    class Student
    {
        String name, address;
        public int age, id, grade;
    
     public void getData()
        {
            Console.WriteLine("Please Enter your Name");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your Address");
            address = Console.ReadLine();
            Console.WriteLine("Please Enter your Age");
            age = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your ID");
            id = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter your grade");
            grade = Int32.Parse(Console.ReadLine());
        
        }

        public void showData()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Address = " + address);
            Console.WriteLine("age = " + age);
            Console.WriteLine("Id = " + id);
            Console.WriteLine("Grade = " + grade);
        }

        public virtual Boolean IsPassed()
        {
            return true;
        }
    }

    class graduate : Student
    {
        public override bool IsPassed()
        {
            if (grade >= 80)
            {
                return true;
            }
            else
            {
                return false;
            }
           
        }
    }
    
    class undergraduate : Student
    {
        public override bool IsPassed()
        {
            if(grade>=70)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students Graduation & UnderGraduation Result Program Implemented by Rushikesh_21\n");
            graduate g = new graduate();
            Console.WriteLine("__________Please Enter Graduation Details________");
            g.getData();

            Console.WriteLine("_______________________");
            g.showData();
            g.IsPassed();

            if (g.IsPassed() == true)
            {
                Console.WriteLine("Congratulations! you have Successfully Passed in Graduation");
            }
            if (g.IsPassed() == false)
            {
                    Console.WriteLine("Regret to inform you that you have failed"); 
            }
            

            undergraduate ug = new undergraduate();
            Console.WriteLine("____________Please Enter Under Graduate Details___");
            ug.getData();

            Console.WriteLine("_____________________________");
            ug.showData();
            ug.IsPassed();

            if(ug.IsPassed() == true)
            {
                Console.WriteLine("Congratulations! You have successfully Passed UnderGraduation");
            }
            if (ug.IsPassed() == false)
            {
                Console.WriteLine("Regret to inform you that you have failed");
            }
        }
    }
}
