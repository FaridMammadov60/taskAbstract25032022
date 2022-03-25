using System;

namespace AbstractConsoleApp.Models
{
    internal class Rectangular : Fiqure
    {
        #region Fields
        double length;
        double width;
        #endregion

        #region Construction
        public Rectangular(double length, double width)
        {
            this.Length = length;
            this.Width = width;
        }
        #endregion

        #region Property
        public double Length
        {
            get { return length; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        do
                        {
                            Console.Write("Menfi eded ola bilmez yeniden daxil edin: ");
                            value = Convert.ToDouble(Console.ReadLine());
                        } while (value < 0);
                        length = value;
                    }
                    length = value;
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }

            }

        }
        public double Width
        {
            get { return width; }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        do
                        {
                            Console.Write("Menfi eded ola bilmez yeniden daxil edin: ");
                            value = Convert.ToDouble(Console.ReadLine());
                        } while (value < 0);
                        width = value;
                    }
                    width = value;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        #endregion

        public override double CalcArea()
        {
            return width * length;
        }

    }
}
