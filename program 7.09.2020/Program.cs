using System;

namespace program_7._09._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give a denary number");
            string s = Console.ReadLine();
            int[] bin = new int[9];
            int c;
            try
            {
                c = Convert.ToInt32(s);
                for(int k = 7; k > 0; k--)
                {
                    bin[k] = c % 2;
                    c = c / 2;
                }
                for (int k = 0; k < 10; k++)
                {
                    Console.WriteLine(bin[k]);
                }
            }
            catch { Console.WriteLine("Invalid"); }
        }
    }
}
