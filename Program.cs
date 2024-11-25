using System;
namespace intValues 
{
    public class intValues
    {
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
                for (int i = 0;i < quants.Length; i++)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Valor número {i + 1}");
                    Console.WriteLine(quants[i]);
                }
            }
            catch
            {
                Console.WriteLine("Error en l'execucuó");
            }
        }
    }
}