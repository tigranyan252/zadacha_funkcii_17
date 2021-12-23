using System;

namespace zadacha_5_17_variant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter base");
            int Base = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            char[] Num = Console.ReadLine().ToCharArray();
            int sum = 0;

            for (int i = Num.Length - 1; i >= 0; i--)
            {
                int digit = int.Parse(Num[i].ToString());
                sum += digit * (int)Math.Pow(Base, Math.Abs(i - (Num.Length - 1)));
            }

            Console.WriteLine(sum);
        }
    }
}