namespace CostNl_2._1.net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            Console.WriteLine("Вас приветсвует йобаное казино");
            for (;;)
            {
                Console.WriteLine("\nСделайте ставку то 5$ до 100$, з шагом 5$");
                double bid = double.Parse(Console.ReadLine());
                if ((bid % 5 == 0) && (bid > 0) )
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("\nНекорректный ввод.");
                }

                
            }
        }
    }
}
