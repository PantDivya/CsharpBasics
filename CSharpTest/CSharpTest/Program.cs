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
            
            //Conditions and If else statements
            string FName = " ";
            Console.WriteLine("Enter your first name");
            FName= Console.ReadLine();

            string LName = " ";
            Console.WriteLine("Enter your Last Name");
            LName= Console.ReadLine();


            if (FName == "Divya" && LName == "Pant")
            {
                Console.WriteLine("We have your name");
            }
            else if(FName == "Divya")
            {
                Console.WriteLine("We have your first name");
            }else if(LName == "Pant")
            {
                Console.WriteLine("We have your Last name");
            }
            else
            {
                Console.WriteLine("Name not found");
            }
//Switch statement
            int day = 3;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
            }
            //For loop
               int i,j,n;
   
	Console.Write("\n\n");
    Console.Write("Display the pattern like pyramid containing odd number of asterisks:\n");
    Console.Write("----------------------------------------------------------------------");
    Console.Write("\n\n");   
   
   Console.Write("Input number of rows for this pattern :");
   n= Convert.ToInt32(Console.ReadLine());    
   for(i=0;i<n;i++)
   {
     for(j=1;j<=n-i;j++)
     Console.Write(" ");
     for(j=1;j<=2*i-1;j++)
       Console.Write("*");
     Console.Write("\n");
   }
            Console.ReadLine();

        }
    }
}
