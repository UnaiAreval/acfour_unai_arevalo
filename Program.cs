using System;
namespace intValues 
{
    public class intValues
    {
        public static void printer(ref int[] quants)
        {

            for (int i = 0; i < quants.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Valor número {i + 1}: {quants[i]}");
            }
        }
        public static void Main()
        {
            int quantiti;
            try
            {
                Console.WriteLine("Introdueix la quantitat de valors que vols introduir");
                quantiti = Convert.ToInt32(Console.ReadLine());
                int[] quants = new int[quantiti];
                for (int i = 0; i < quantiti; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine("Introdueix un valor enter");
                    quants[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine("Els valors són:");
                printer(ref quants);

                for (int i = 1; i < quantiti; i++)
                {
                    for (int j = 0; j < quantiti - 1; j++)
                    {
                        int order;
                        if (quants[j] < quants[i])
                        {
                            order = quants[j];
                            quants[j] = quants[i];
                            quants[i] = order;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Els valors endresats de més gran a més petit són:");
                printer(ref quants);
            }
            catch
            {
                Console.WriteLine("Error en l'execucuó");
            }
        }
    }
}