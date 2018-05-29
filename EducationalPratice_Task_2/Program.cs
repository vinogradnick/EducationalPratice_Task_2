using System;

namespace EducationalPratice_Task_2
{
    class Program
    {
        private static int Number;
        static string iToString(int i)
        {
            string s = "";
            while (i > 0)
            {
                s = (char) (i % 10 + '0')+s;
                i /= 10;
            }
            return s;
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
                for (int i = q; i + sum < Number; i++) //отчет с заданого значение, если в начале то 1
                    Calc(i + sum, s + iToString(i) + '+', i);
                return;
            }
            for (int i = q; i + sum <= Number; i++)
            {
              
                Calc(i + sum, s + iToString(i) + '+', i);
            }
            return;
        }
        static void Main(string[] args)
        {
            Number = Convert.ToInt32(Console.ReadLine());

            Calc(0,"",1);

            Console.ReadLine();
        }
    }
}
