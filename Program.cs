using System;

namespace C_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            string fname,lname;
            Console.Write("Enter your first name : ");
            fname = Console.ReadLine();
            Console.Write("Enter your last name : ");
            lname = Console.ReadLine();
            Console.Write("Your full name is "+fname+" "+lname);
        }
    }
}
