namespace Topic_4___User_Input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Topic 4 - User Input";

            // Console.WriteLine is used to output text to the console
            // Console.ReadLine is used to read input from the user

            String username;
            int age;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Please enter your username: ");
            username = Console.ReadLine();

            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello, " + username + " I welcome you to the world of C3!");
            Console.WriteLine(" ");

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

            Console.ForegroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.Write("Enter your age: ");
            Int32.TryParse(Console.ReadLine(), out age);
            // The above line will try to convert the input to an integer. If it is successful, it will store the value in the variable age.
            // If it is not successful, it will store 0 in the variable age and will not give an error.
            Console.WriteLine("Your age is: " + age);

            /*
              This will return true or false depending on whether the conversion was successful or not.
              Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age)); 
            */
         

            Console.ReadLine(); // To stop the window from closing immediately after executing the program

        }
    }
}
