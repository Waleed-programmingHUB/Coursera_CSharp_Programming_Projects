using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coreObjectOrientedConcepts
{
    internal class Student
    {
        // Data members
        private int studentID;
        private string studentName;

        // Default Constrcutor 
        public Student() 
        {
            studentID = 220208731;
            studentName = "Waleed Ali Sarwar";
        }
        // parameterized contructor
        public Student(int id,string name)
        {
            studentID = id;
            studentName = name;
        }
        

        // Member functions
        public void acceptDetails() {
           Console.WriteLine("Enter Student ID :");
           studentID = int.Parse(Console.ReadLine());
            
           Console.WriteLine("Enter Student Name :");
           studentName = Console.ReadLine();
        }

        public void displayDetails()
        {
            Console.WriteLine();
            Console.WriteLine("Student Id : " + studentID);
            Console.WriteLine("Student Name : " + studentName);
        }
    }
}
