using System;

namespace Task_3_drobi
{
    class Fraction
    {

        int num;
        // Числитель
        int den;
        // Знаменатель

        public int _num
        {
            get { return num; }
            set { value = num; }
        }

        /// <summary>
        /// Знаменатель
        /// </summary>
        public int _den
        {
            get { return den; }
            set { value = den; }
        }


        public Fraction(int num, int den)
        {

            if (den == 0)
            {
                throw new Exception("Недопустимое значение знаменателя.");
            }

            this.num = num;
            this.den = den;
        }



        public Fraction Plus(Fraction other)
        {
            var _den = den * other.den;
            var _num = num * other.den + other.num * den;
            return new Fraction(_num, _den);
        }

        public Fraction Minus(Fraction other)
        {
            var _den = den * other.den;
            var _num = num * other.den - other.num * den;
            return new Fraction(_num, _den);
        }

        public Fraction Multi(Fraction other)
        {
            //Fraction res = new Fraction(num * other.num, den * other.den);
            //return res;

            return new Fraction(num * other.num, den * other.den);
        }


        public Fraction Divide(Fraction other)
        {
            //Fraction res = new Fraction(num * other.den, den * other.num);
            //return res;

            return new Fraction(num * other.den, den * other.num);
        }

        private void Sokr() 
        {
            var _num = Math.Abs(num);
            var _den = Math.Abs(den);
            int temp;

            while (_num != 0 && _den != 0)
            {
                if (_num % _den > 0)
                {
                    temp = _num;
                    _num = _den;
                    _den = temp % _den;
                }
                else
                    break;
            } 

            if (_num != 0 && _den != 0)
            {
                num = num / _den;
                den = den / _den;
            }
        }  

        public override string ToString()
        {
            Sokr();  
            return $"{num}/{den}"; 
        }


    }

    class Program
    {
        static void Main(string[] args)
        {

            Fraction Fraction01 = new Fraction(3, 4);
            //Fraction01.num = 3;
            //Fraction01.den = 4;


            Fraction Fraction02 = new Fraction(7, 8);
            //Fraction02.num = 7;
            //Fraction02.den = 8;



            Console.WriteLine($"Сумма дробных чисел {Fraction01} и {Fraction02} равно {Fraction01.Plus(Fraction02)};");
            Console.WriteLine();
            Console.WriteLine($"Разность дробных чисел {Fraction01} и {Fraction02} равно {Fraction01.Minus(Fraction02)};");
            Console.WriteLine(); 

            Console.WriteLine($"Произведение дробных чисел {Fraction01} и {Fraction02} равно {Fraction01.Multi(Fraction02)};");
            Console.WriteLine();
            Console.WriteLine($"Частное дробных чисел {Fraction01} и {Fraction02} равно {Fraction01.Divide(Fraction02)};");
            Console.WriteLine();

            Console.ReadKey();

        }
    }
}

