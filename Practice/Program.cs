namespace Practice;

class Program
{
    static void Main(string[] args)
    {
        for (int w = 0; w < 4; w++)
        {
            for (int count = 1; count < 10; count++)
            {

                for (int j = 0; j < count; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            Console.WriteLine($"" +
                              $"");
            
            for (int coun = 9; coun > 0; coun--)
            {
                for (int i = 0; i < coun; i++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }

            for (int cou = 10; cou >= 1; cou--)
            {
                Console.Write(new string(' ', cou - 1));
                for (int i = 0; i < (11 - cou); i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"" +
                              $"" +
                              $"" +
                              $"");

            for (int co = 0; co < 11; co++)
            {
                Console.Write(new string(' ', co + 0));
                for (int i = 0; i < (10 - co); i++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }

    }
}