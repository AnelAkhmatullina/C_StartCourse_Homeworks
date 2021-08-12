using System;

namespace Task_1A
{
    struct Complex
    {
        public double re;
        //Действительная часть комплексного числа

        public double im;
        //Мнимая часть комплексного числа


        public Complex Plus(Complex other)
        {
            Complex res;
            res.re = re + other.re;
            res.im = im + other.im;

            return res;
        }

        public Complex Minus(Complex other)
        {
            Complex res;
            res.re = re - other.re;
            res.im = im - other.im;

            return res;
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

            Complex complex01;
            complex01.re = 3;
            complex01.im = 2;

            Complex complex02;
            complex02.re = 0;
            complex02.im = -1;




            Console.WriteLine($"Сумма комплексных чисел {complex01} и {complex02} равна {complex01.Plus(complex02)}");
            Console.WriteLine($"Разность комплексных чисел {complex01} и {complex02} равна {complex01.Minus(complex02)}");

            Console.ReadKey();
        }
    }
}

