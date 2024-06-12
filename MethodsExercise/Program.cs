using System.Security.Cryptography.X509Certificates;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Madlib();

            int added = Add(2, 2);
            Console.WriteLine(added);

            int subtracted = Subtract(10, 5);
            Console.WriteLine(subtracted);

            int mult = Multiply(2, 5);
            Console.WriteLine(mult);

            int div = Divide(4, 2);
            Console.WriteLine(div);

            int result = Sum(5, 5, 5, 5, 5);
            Console.WriteLine(result);
        }

            public static void Madlib()
        {

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favorite color?");
            string favcolor = Console.ReadLine();
            Console.WriteLine("Favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine($"One day, {userName} was walking through the woods while wearing a {favcolor} t-shirt. {userName} saw a {favAnimal} listening to {favBand}.");



        }

        public static int Add(int numOne, int numTwo)
        {
            int sum = numOne + numTwo;
            return numOne + numTwo;
        }

        public static int Subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;

        }

        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;

        }


        public static int Divide(int numONe, int numTwo)
        {
            return numONe / numTwo;

        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

    }
}




    
