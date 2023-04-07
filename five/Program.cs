using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Пользователь вводит словами цифру от 0 до 9. Прило-
//жение должно перевести слово в цифру. Например, если
//пользователь ввёл five, приложение должно вывести на
//экран 5.

namespace five
{
    enum Numbers
    {
        zero = 0,
        one,
        two, 
        three,
        four,
        five,
        six,
        seven,
        eight,
        nine,
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            for (Numbers i = Numbers.zero; i <= Numbers.nine-1; i++)
            {
                Console.WriteLine(i + "\t - это " + " номер - " + (int)i);
            }           
            Console.WriteLine("Please enter your word: ");
           string word= Console.ReadLine();

            Numbers num;
            if (Enum.TryParse(word, true, out num)) 
            {
                int digit = (int)num; // приводим к интовому значению
                Console.WriteLine($"это {digit}");
            }
            else
            {
                Console.WriteLine("Ошибка в слове");
            }

        }
    }
}
