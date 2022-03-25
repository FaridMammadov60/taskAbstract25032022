using System;

namespace AbstractConsoleApp.Models
{
    internal class Square : Fiqure
    {
        #region Fields
        double side;
        #endregion

        #region Construction
        public Square(double side)
        {
            this.Side = side;
        }
        #endregion

        #region Property
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                    L1:
                        Console.Write("Menfi eded ola bilmez yeniden daxil edin: ");
                        value = Convert.ToDouble(Console.ReadLine());
                        if (value < 0)
                        {
                            goto L1;
                        }

                    }
                    side = value;
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
            return side * side;
        }
    }
}
