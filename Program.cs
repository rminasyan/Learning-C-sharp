namespace C#Project
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

            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(num1 + num2);

            Console.ReadLine();
        }
    }
}
