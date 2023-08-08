using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac3_1_student
{
    public class Student
    {
        String name;
        int roll_no;

        public void getData()
        {
            Console.WriteLine("Please Enter your Name");
            name = Console.ReadLine();
            Console.WriteLine("Please Enter your Roll No.");
            roll_no = int.Parse(Console.ReadLine());
        }
        public void displayData()
        {
            Console.WriteLine("Name = " + name);
            Console.WriteLine("Roll No = " + roll_no);
        }
    }
    public class test : Student
    {
        public int AIML, IS, IOT, MFCS2, DMBA;
        public void getMarks()
        {
            getData();

            Console.WriteLine("Enter your AIML Marks");
            AIML = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your IS Marks");
            IS = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your IOT Marks");
            IOT = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your MFCS2 Marks");
            MFCS2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your DMBA Marks");
            DMBA = int.Parse(Console.ReadLine());
        }

        public void displayMarks()
        {
            displayData();

            Console.WriteLine("AIML Marks = " + AIML);
            Console.WriteLine("IS Marks = " + IS);
            Console.WriteLine("IOT Marks = " + IOT);
            Console.WriteLine("MFCS2 Marks = " + MFCS2);
            Console.WriteLine("DMBA Marks = " + DMBA);
        }
    }

    public class result : test
    {
        int total;
        String grade;
        public void calculate()
        {
            getMarks();
            total = AIML + IS + IOT + MFCS2 + DMBA;
            if (total > 75)
            {
                grade = "Congratulations you have passed with Distinction";
            }

            else if (total >= 60 && total < 75)
            {
                grade = "Congratulations you have passed with A Class";
            }
            else if (total >= 40 && total < 60)
            {
                grade = "Congratulations you have passed with B Class";
            }

            else
            {
                grade = " Regret to inform you that you have failed";
            }

        }

        public void displaygrade()
        {
            Console.WriteLine("_____________________");
            displayMarks();
            Console.WriteLine("Total = " + total);
            Console.WriteLine("Grade = " + grade);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Students Grade Program Implemented by Rushikesh_21\n");
            result r = new result();
            r.calculate();
            r.displaygrade();

        }

    }
}