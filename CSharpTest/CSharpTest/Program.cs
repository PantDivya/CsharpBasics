using System;

namespace CSharpTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string FirstName = "Divya";
            string LastName = "Pant";
            //Create a variable of type string and assign it a value
            string greetings = "Have a nice day!";
            Console.WriteLine(greetings);
            Console.WriteLine("The length is: " + greetings.Length);
            Console.WriteLine("In upper case: " + greetings.ToUpper());
            Console.WriteLine("In lower case: " + greetings.ToLower());

            //Concatenation
            string Name = "My name is " FirstName + LastName;
            Console.WriteLine(Name);

            //Interpolation
            string name = $"My name is { FirstName} { LastName }";
            Console.WriteLine(name);

            Console.ReadLine();

        }
    }
}
