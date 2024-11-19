namespace CostNl_2._4.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            for (; ; )
            {
                int attempts = 0, namber_one = 0, namber_tuo = 0, namber_thre = 0, namber_four = 0;

                // Генерация случайного 4-значного пароля
                Console.WriteLine("Программа загадала 4-значный пароль. Попробуйте угадать его!");
                string Password = random.Next(1000, 10000).ToString();

                for (; ; )
                {
                    Console.Write("Введите ваш вариант: ");

                    Console.WriteLine($"{namber_one}{namber_tuo}{namber_thre}{namber_four}");
                    string input = "";
                    input += $"{namber_one}{namber_tuo}{namber_thre}{namber_four}";

                    attempts++;// + попытка

                    // Проверка з паролем
                    string check = "";
                    for (int i = 0; i < 4; i++)
                    {
                        if (input[i] == Password[i])
                        {
                            check += input[i]; // Якщо число и позиция правильная
                        }
                        else
                        {
                            check += "X"; // Вводими "X" как не верное

                            switch (i)
                            {
                                case 0:
                                    namber_one++;
                                    break;
                                case 1:
                                    namber_tuo++;
                                    break;
                                case 2:
                                    namber_thre++;
                                    break;
                                case 3:
                                    namber_four++;
                                    break;
                            }
                        }
                    }

                    Console.WriteLine($"Результат: {check}");

                    // Якщо пароль угадано
                    if (check == Password)
                    {
                        Console.WriteLine($"Поздравляем! Вы угадали пароль: {Password}");
                        Console.WriteLine($"Количество попыток: {attempts}");

                        Console.WriteLine("\nНажмите любую клавишу для продолжения...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    }
                }
            }
        }
    }
}
