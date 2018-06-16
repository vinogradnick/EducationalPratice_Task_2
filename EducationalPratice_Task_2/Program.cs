using System;

namespace EducationalPratice_Task_2
{
    class Program
    {
        private static int Number;
        static string concat(int value)
        {
            string temp = "";
            while (value > 0)
            {
                temp = (char)(value % 10 + '0') + temp;
                value /= 10;
            }
            return temp;
        }
        /// <summary>
        /// Разложение числа на слагаемые
        /// </summary>
        /// <param name="sum">сумма </param>
        /// <param name="s">выходная строка</param>
        /// <param name="q"> число по которому будет использовано для разложения </param>
        static void Calc(int sum, string s, int q)
        {
            if (sum == Number)//Если сумма равна заданому числу
            {
                Console.WriteLine(s.Substring(0, s.Length - 1));
                return;//Останавливаем рекурсию
            }

            if (sum == 0)//Первый проход когда сумма 0
            {
                for (int i = q; i + sum < Number; i++) //отчет с 


                    Calc(i + sum, s + concat(i) + '+', i);
                return;
            }

            for (int i = q; i + sum <= Number; i++)

                Calc(i + sum, s + concat(i) + '+', i);
            return;
        }
        static void Main(string[] args)
        {
            Number = Convert.ToInt32(Console.ReadLine());

            Calc(0, "", 1);

            Console.ReadLine();
        }
    }
}