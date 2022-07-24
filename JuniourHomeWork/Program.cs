
namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtArray = 0;
            int[] numbers = {lenghtArray};
            int[] numbersCopy = {lenghtArray};
            bool exit = false;
            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)          // Вывод стартового массива
            {
                Console.WriteLine("Исходные значения массива: " + numbers[i] + ". Длина массива: " + numbers.Length);
            }

            while (exit != true)
            {
                Console.WriteLine("Введите число, команду sum, чтобы сложить значения ввода или команду exit, чтобы выйти.");
                string userInput = Console.ReadLine();

                if (userInput != "sum" && userInput != "exit")
                {

                    int convertStringToNumber = Convert.ToInt32(userInput);

                    for (int i = 0; i < numbersCopy.Length; i++)
                    {
                        numbersCopy[i] = numbers[i];
                    }

                    numbersCopy[numbers.Length - 1] += convertStringToNumber;
                    numbersCopy = numbers;
                }

                if (userInput == "sum")
                {

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine("Сумма элементов равна: " + sum);
                    sum = 0;
                }

                else if (userInput == "exit")
                {
                    Console.Clear();
                    exit = true;
                    Console.SetCursorPosition(50, 5);
                    Console.WriteLine("До свидания!");
                }

            }
            }
        }

    }

