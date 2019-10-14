using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;
            x = 7;
            y = x + 3;
            System.Console.WriteLine(y);
            Console.ReadLine();
            */
            Console.WriteLine("What is your name?");
            Console.Write("Type your First Name: ");
            string myFirstName;
            myFirstName = Console.ReadLine();


            string myLastName;
            Console.Write("Type your Last Name: ");
            myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();

        }
    }
}
