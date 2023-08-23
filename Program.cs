using System;

namespace DaireCizimUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dairenin yarıçapı: ");
            double yaricap = Convert.ToDouble(Console.ReadLine());

            DaireCizici daireCizici = new DaireCizici();
            daireCizici.DaireCiz(yaricap);
        }
    }

    class DaireCizici
    {
        public void DaireCiz(double yaricap)
        {
            int daireCevresi = (int)Math.Ceiling(2 * Math.PI * yaricap);

            for (int i = 0; i <= 2 * yaricap; i++)
            {
                for (int j = 0; j <= 2 * yaricap; j++)
                {
                    double uzaklikMerkezden = Math.Sqrt(Math.Pow(i - yaricap, 2) + Math.Pow(j - yaricap, 2));
                    if (Math.Abs(uzaklikMerkezden - yaricap) < 0.5)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}