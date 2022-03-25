using AbstractConsoleApp.Models;
using System;
using System.Text;

namespace AbstractConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.Unicode;
                Console.InputEncoding = Encoding.Unicode;
            L1:
                Console.WriteLine("1 daxil etsəniz Square-in CalcArea methodu çalıçacaq\n" +
                    "\n" +
                    "2 yazıb daxil etsəniz Rectangular-in CalcArea methodu çalışacaq\n" +
                    "\n" +
                    "0 yazıb daxil etseniz proqram sonlanacaq.\n" +
                    "");

                Console.Write("0, 1, 2 rəqəmlərindən birini daxil edin: ");
                int num = Convert.ToInt32(Console.ReadLine());
                switch (num)
                {
                    case 0:
                        break;
                    #region Kvadrt
                    case 1:
                        Console.Write("Kvadratın tərəfini daxil edin: ");
                        double s = Convert.ToDouble(Console.ReadLine());
                        Square square = new Square(s);
                        Console.Write("Kvadratın sahəsi: ");
                        Console.WriteLine(square.CalcArea());
                        break;
                    #endregion

                    #region Duzbucaqli
                    case 2:
                        Console.Write("Düzbucaqlının uzunluğunu daxil edin: ");
                        double l = Convert.ToDouble(Console.ReadLine());
                        Console.Write("Düzbucaqlının enini daxil edin: ");
                        double w = Convert.ToDouble(Console.ReadLine());
                        Rectangular rectangular = new Rectangular(l, w);
                        Console.Write("Düzbucaqlının sahəsi: ");
                        Console.WriteLine(rectangular.CalcArea());
                        break;
                    #endregion

                    default:
                        Console.Clear();
                        Console.WriteLine("Düzgün daxil edilməyib");
                        goto L1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
         
        }
    }
}
