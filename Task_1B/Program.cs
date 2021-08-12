using System;

namespace Task_1B
{

    class Complex
    {

        double re;
        // Действительная часть комплексного числа
        double im;
        // Мнимая часть комплексного числа


        #region Public Properties

        public double Re
        {
            get
            {
                return re;
            }
            set
            {
                re = value;
            }
        }

        public double Im
        {
            get
            {
                return im;
            }
            set
            {
                if (value == 0)
                {
                    throw new Exception("Недопустимое значение мнимой части комплексного числа.");
                }

                im = value;

            }
        }

        #endregion



        public Complex(double re, double im)
        {

            if (im == 0)
            {
                throw new Exception("Недопустимое значение мнимой части комплексного числа.");
            }

            this.re = re;
            this.im = im;
        }


        public Complex Plus(Complex other)
        {
            //Complex res = new Complex(re + other.re, im + other.im);
            //return res;

            return new Complex(re + other.re, im + other.im);
        }

        public Complex Minus(Complex other)
        {
            //Complex res = new Complex(re - other.re, im - other.im);
            //return res;

            return new Complex(re - other.re, im - other.im);
        }

        public Complex Multi(Complex other)
        {
            //Complex res = new Complex(re * other.re, im * other.im);
            //return res;

            return new Complex(re * other.re, im * other.im);
        }

        public override string ToString()
        {
            return im < 0 ? $"{re} - {-im}i" : $"{re} + {im}i"; 
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Complex complex01 = new Complex(3, 2);
            //complex01.re = 3;
            //complex01.im = 2;


            Complex complex02 = new Complex(0, -1);
            //complex02.re = 0;
            //complex01.re = -1;


            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} равна {complex01.Plus(complex02)};");
            Console.WriteLine();
            Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} равна {complex01.Minus(complex02)};");
            Console.WriteLine();
            Console.WriteLine($"Произведение комплексных чисел {complex01} и {complex02} равно {complex01.Multi(complex02)}.");

            Console.ReadKey();

        }
    }
}

