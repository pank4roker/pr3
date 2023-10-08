using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Запросить у пользователя 1 слово, после чего вывести три столбца,
            //каждый через промежуток в несколько символов от предыдущего,
            //содержащие по три строки с введенным пользователем словом.
            //Использовать 7 функции вывода.
            Write("Введите слово: ");
            string word_1 = ReadLine();

            Write($"\n{word_1} *** {word_1}");
            WriteLine($" *** {word_1}");
            Write($"{word_1}");
            Write($" *** ");
            WriteLine($"{word_1} *** {word_1}");
            Write($"{word_1}");
            WriteLine($" *** {word_1} *** {word_1}");
            ReadKey();
        }
    }
}
