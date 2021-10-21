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

            //Calculator

            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
