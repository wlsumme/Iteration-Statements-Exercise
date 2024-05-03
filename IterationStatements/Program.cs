namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Thousands()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void Threes()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void Equal(int x, int y)
        {
            if (x == y)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }


        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
        }


        //Write a method to check whether a given number is positive or negative
        public static void PosOrNeg(int t)
        {
            if (t > 0)
            {
                Console.WriteLine("the number is positive.");
            }
            else if (t < 0)
            {
                Console.WriteLine("the number is negative.");
            }
            else
            {
                Console.WriteLine("i dont know what zero is/ not a number");
            }
        }

        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void OldEnough()
        {
            Console.WriteLine("Please enter you age to see if you can vote.");
            int userAge = int.Parse(Console.ReadLine());
            if (userAge >= 18)
            {
                Console.WriteLine($"Congrats {userAge} is old enough to vote!");
            }
            else
            {
                Console.WriteLine($"Sorry {userAge} isnt old enough to vote.");
            }

        }

        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Tens()
        {
            Console.WriteLine("Enter a number.");
            int userNumber = int.Parse(Console.ReadLine());
            if (userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is in the range of -10 and ten");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the range of -10 to 10");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void Multi12(int number)
        {
            for(int i = 1; i <= 12;  i++)
            {
                int result = number * i;
                Console.WriteLine($"{result}");
            }

        }


        //Call the methods to test them in the Main method below
        public static void Main(string[] args)
        {
            Thousands();
            Threes();
            Equal(6, 5);
            EvenOrOdd(53);
            PosOrNeg(-45);
            OldEnough();
            Tens();
            Multi12(5);


        }
    }
}
