using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Игра 'Угадай число' ===\n");

            Random random = new Random();
            int secretNumber = random.Next(1, 101); // Число от 1 до 100
            int attempts = 0;
            int guess = 0;

            Console.WriteLine("Я загадал число от 1 до 100.");
            Console.WriteLine("Попробуй угадать!\n");

            while (guess != secretNumber)
            {
                Console.Write("Введи свой вариант: ");
                string input = Console.ReadLine();

                // Проверяем, ввел ли пользователь число
                if (!int.TryParse(input, out guess))
                {
                    Console.WriteLine("Это не число! Попробуй еще раз.\n");
                    continue;
                }

                attempts++;

                if (guess < secretNumber)
                {
                    Console.WriteLine("Больше! Попробуй еще.\n");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("Меньше! Попробуй еще.\n");
                }
                else
                {
                    Console.WriteLine($"\nПоздравляю! Ты угадал число {secretNumber} за {attempts} попыток!");
                }
            }

            Console.WriteLine("\nНажми любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}