namespace CostNl_2._1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int bid, one, tuo, thre;
            int hack = 42, bid_hack = 5; // читы
            string kazino = "$Казино$"; //Название йобаного казино

            Console.WriteLine("Вас приветсвует йобаное казино");

            for (; ; )
            {
                for (; ; )
                {
                    Console.WriteLine("\nСделайте ставку то 5$ до 100$, з шагом 5$");
                    bid = int.Parse(Console.ReadLine());
                    if (((bid % 5 == 0) && (bid > 0) && (bid < 100)) || (bid == hack))
                    {
                        Console.Clear();
                        break;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(kazino);
                        Console.WriteLine("\nНекорректный ввод");
                    }

                }
                if (bid == hack) //Хак
                {
                    bid = bid_hack;
                    Console.WriteLine(kazino);
                    Console.WriteLine($"Ля ты криса но ставка будет = {bid}");
                    one = 7;
                    tuo = 7;
                    thre = 7;
                }
                else //Рандом
                {
                    Console.WriteLine(kazino);
                    one = random.Next(1, 10);
                    tuo = random.Next(1, 10);
                    thre = random.Next(1, 10);
                }
                Console.WriteLine($"\n{one}{tuo}{thre}");
                
                //+++
                if ((one == tuo) || (one == thre))
                { 
                    
                }
            }
        }
    }
}
