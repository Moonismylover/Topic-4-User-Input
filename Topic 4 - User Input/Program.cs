using System.Net.Security;

namespace Topic_4___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - User Input";

            // Console.WriteLine is used to output text to the console
            // Console.ReadLine is used to read input from the user

            String username, customer, pizzaTopping, customerTwo;
            int age;
            double priceFirst, priceSecond, item, diameter;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter your username: ");
            username = Console.ReadLine();

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello, " + username + ", I welcome you to the world of C#! Please continue by pressing ENTER!");
            Console.WriteLine(" ");

            Console.ReadKey(); // Stops the program from closing immediately after executing the program, and waits for the user to press a key.
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.BackgroundColor = ConsoleColor.White;

            /*
            Console.Write("Enter your age: ");
            age = Console.ReadLine();
            // This line gives a error because Console.ReadLine() returns a string and age is an integer.
            Console.WriteLine("Your age is: " + age);
            Console.ReadLine(); //To stop the window from closing immediately after executing the program
            */

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());
            // Whatever in put into Convert.ToInt32() will be converted to an integer, if it is possible. If not, it will give an error.
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter your age: ");
            Int32.TryParse(Console.ReadLine(), out age);
            // The above line will try to convert the input to an integer. If it is successful, it will store the value in the variable age.
            // If it is not successful, it will store 0 in the variable age and will not give an error.
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine(" ");

            /*
              This will return true or false depending on whether the conversion was successful or not:
              Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age)); 
            */

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;

            Console.Write("What is the price of the first item? \nEnter here: ");
            Double.TryParse(Console.ReadLine(), out priceFirst);
            Console.WriteLine("The price is " + priceFirst.ToString("C"));
            Console.WriteLine("Congrats! We have a 50% discount on this item, the new price is " + (priceFirst * 0.5).ToString("C"));

            Console.WriteLine(" ");

            Console.Write("What is the price of the second? \nEnter here: ");
            Double.TryParse(Console.ReadLine(), out priceSecond);
            Console.WriteLine("The price is " + priceSecond.ToString("C"));
            Console.WriteLine("Congrats! We have a 20% discount on this item, the new price is " + (priceSecond * 0.2).ToString("C"));
            
            Console.WriteLine(" ");
            Console.WriteLine("Now, let's move on to the next task! Please press any key to continue...");

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            // Task 1

            Console.WriteLine("~~~~~~~~~~ Task 1 ~~~~~~~~~~");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");

            Console.Write("Hey! Welcome to Triple Pizza! \nPlease enter your name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            customer = Console.ReadLine();

            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(customer + ", please enter your favourite pizza topping: ");
            Console.ForegroundColor = ConsoleColor.Red;
            pizzaTopping = Console.ReadLine();

            Console.WriteLine(" ");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("How awesome, " + customer + "! I also love eating " + pizzaTopping + "!");

            Console.WriteLine(" ");
            Console.WriteLine("Please press ENTER to continue...");

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            // Task 2

            Console.WriteLine("~~~~~~~~~~ Task 2 ~~~~~~~~~~");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ");

            Console.Write("Hey! Welcome to Walmart! \nPlease enter your name: ");
            Console.ForegroundColor = ConsoleColor.Red;
            customerTwo = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("I hope you are having a good day, " + customerTwo + "!");

            Console.WriteLine(" ");

            Console.Write("Please enter the price of the item you want to buy: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Double.TryParse(Console.ReadLine(), out item);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("The price of buying three of these items is " + (item * 3).ToString("C") + ".");

            Console.WriteLine(" ");
            Console.WriteLine("Please press ENTER to continue...");

            Console.ReadKey();
            Console.ResetColor();
            Console.Clear();

            // Task 3

            Console.WriteLine("~~~~~~~~~~ Task 3 ~~~~~~~~~~");   
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Hey! Enter a diameter for your circle: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Double.TryParse(Console.ReadLine(), out diameter);
            Console.WriteLine("The radius of a circle with the diameter of " + diameter + " is " + (diameter / 2).ToString("F2") + ".");

            Console.ReadLine(); // To stop the window from closing immediately after executing the program

            /* 
            Why are there so much different types of integers?
            
            Short (16-bit) is used when you want to save memory and you know that the value will not exceed 32,767 or be less than -32,768.
            Int (32-bit) is the most commonly used integer type and can store values from -2,147,483,648 to 2,147,483,647.
            Long (64-bit) is used when you need to store very large numbers,from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807.
           
            Signed integers (short, int, long) can store both positive and negative numbers, 
            while unsigned integers (ushort, uint, ulong) can only store positive numbers and zero.

            */

        }
    }
}
