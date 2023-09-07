namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var blah = Multiply(60, 2, 4);

            //---------------Exercise 1--------------------------

            Console.WriteLine("Hello, what is your name?");

            var name = Console.ReadLine();

            Console.WriteLine($"Hi, {name}, what is your favorite color?");

            var color = Console.ReadLine();

            Console.WriteLine($"Thank you {name}, I also like {color}, i think it acsents my skin complexion!");

            Console.WriteLine($"Ok {name}, you like the color {color}, what is your favorite animal?");

            var animal = Console.ReadLine();

            Console.WriteLine($"Cool thanks {name}!");

            Console.WriteLine("Also what is your favorite band?");

            var band = Console.ReadLine();

            Console.WriteLine(
                "Great!" +
                "I will now use the information you provided to write a short story, i hope you enjoy it!");

            Console.WriteLine("------------------------------------------------------------------------------");


            Console.WriteLine(
                $"Today, {name} struggled with the day he was having at his horribly demanding job, and decided he had had enough!" +

                " " +

                $"This dead end plant job had {name} feeling {color}, and he was in desperate need of a change of employment." +

                " " +

                $"After work, {name} rushed home as fast as a {animal} to begin looking for new opportunities for himself." +

                " " +

                $"His first choice was to join his fovorite band, but since {band} wasn't recruiting any new members, {name} decided on an exciting career in computer programming instead!");

            //---------------Exercise 2--------------------------





        }
    }
}
