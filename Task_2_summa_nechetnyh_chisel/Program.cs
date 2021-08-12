using System;

namespace Task_2_summa_nechetnyh_chisel
{
    class Program
    {

        static void Main(string[] args)
        {
            int number;
            int sum = 0; // Объявим перменную для хранения суммы чисел
            bool isNumber;
            do
            {
                Console.Write("Введите число: ");
                var numberInput = Console.ReadLine(); // Получим строку ввода
                isNumber = int.TryParse(numberInput, out number); // Проверим, является ли строка ввода числом

                if (!isNumber) // Если строка ввода не является числом, выведем соответствующую информацию на экран
                {
                    Console.WriteLine($"{numberInput} не является целым числом, будьте внимательны.");
                }
                else
                {
                    // Число должно быть НЕчетным + положительным (метод IsOdd проверяем число на четность)
                    // Если число удовлетворяет условию, прибавляем число к общей сумме, если нет, прибавляем 0 (т. е. по факту, ничего не прибавляем)
                    sum += !IsOdd(number) && number > 0 ? number : 0;
                }
            }
            // Цикл будет работать до тех пор пока мы не введем правильное число и это число не будет равно 0
            while (!(isNumber && number == 0));
            // Как только мы ввели число 0, работа приложения завершается, выводим на экран сумму чисел
            Console.Write($"Cумма нечетных положительных чисел: {sum}");
            Console.ReadKey();
            //И сам метод isOdd

            static bool IsOdd(int n)
            {
                return n % 2 == 0;
            }
        }
    }
} 
