namespace JuniorHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lenghtArray = 0;
            int[] numbers = { lenghtArray };
            int[] numbersCopy = { lenghtArray };
            bool exit = false;

            for (int i = 0; i < numbers.Length; i++)          // Вывод стартового массива
            {
                Console.WriteLine("Исходные значения массива: " + numbers[i] + ". Длина массива: " + numbers.Length);
            }

            while (exit != true)
            {
                Console.WriteLine("Введите число, команду sum, чтобы сложить значения ввода или команду exit, чтобы выйти.");
                string userInput = Console.ReadLine();

                if (userInput == "sum")                                      // Проверка на сумму
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        sum += numbers[i];
                    }

                    Console.WriteLine("Сумма элементов равна: " + sum);
                }

                else if (userInput == "exit")                               // Проверка на выход из программы
                {
                    Console.Clear();
                    exit = true;
                    Console.SetCursorPosition(50, 5);
                    Console.WriteLine("До свидания!");
                }

                else                                                       // Добавление пользовательских значений в массив
                {
                    int convertStringToNumber = Convert.ToInt32(userInput);

                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbersCopy[i] = numbers[i];
                    }

                    numbersCopy[numbers.Length - 1] += convertStringToNumber;
                    numbers = numbersCopy;
                }

            }
        }
    }

}
