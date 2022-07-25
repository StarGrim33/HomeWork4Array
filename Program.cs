namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[0];
            bool exit = false;
            string sumCommand = "sum";
            string exitCommand = "exit";

            while (exit != true)
            {
                Console.WriteLine("Введите число, команду " + sumCommand + ", чтобы сложить значения ввода, или команду " + exitCommand + ", чтобы выйти.");
                string userInput = Console.ReadLine();

                if (userInput == sumCommand)
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine(sumCommand + " элементов равна: " + sum);
                }
                else if (userInput == exitCommand)
                {
                    Console.Clear();
                    exit = true;
                    Console.SetCursorPosition(50, 5);
                    Console.WriteLine(exitCommand);
                }
                else
                {
                    int[] numbersCopy = new int[numbers.Length + 1];
                    int convertStringToNumber = Convert.ToInt32(userInput);
                    numbersCopy[numbersCopy.Length - 1] += convertStringToNumber;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbersCopy[i] = numbers[i];
                    }

                    numbers = numbersCopy;
                }

            }
        }
    }

}
