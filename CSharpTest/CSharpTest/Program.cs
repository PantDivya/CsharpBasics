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
            
            //Access String using index
            Console.WriteLine("   " + FirstName[0]);
            Console.WriteLine("   " + FirstName[1]);
            Console.WriteLine("   " + FirstName[2]);
            Console.WriteLine("   " + FirstName[3]);
            Console.WriteLine("   " + FirstName[4]);
            
            //Find the index position of a specific character
            Console.WriteLine("  " + FirstName.IndexOf("v"));
            Console.WriteLine("  " + FirstName.IndexOf("a"));
            Console.WriteLine("  " + FirstName.IndexOf("y"));
            Console.WriteLine("  " + FirstName.IndexOf("D"));
            Console.WriteLine("  " + LastName.IndexOf("a"));
            Console.WriteLine("  " + LastName.IndexOf("n"));

            Console.ReadLine();

        }
    }
}
