using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moon
{
    class Program
    {
        static void Main(string[] args)
        {
            int j;
            float x;
            float sumcard = 0;

            Console.WriteLine("Введите номер карты:");
            String userInput = Console.ReadLine();
            userInput = parseCard(userInput);

            if (userInput.Length % 2 == 0) { j = 1; } else { j = 2;}

            for (int i = j; i < userInput.Length; i++)
            {
                x = Convert.ToInt64(userInput.Substring(i));
                sumcard = sumcard + (2 * x) > 9 ? 2 * x - 9 : 2 * x; ;
            }
            Console.WriteLine("Полученная сумма:" + sumcard);
            Console.WriteLine(sumcard % 2 == 0 ? "Номер карты верный" : "Номер карты неверный");
            Console.ReadKey();
        }
        private static string parseCard(string userInput)
        {
            float CardNumLocal;
            if (userInput == null)
                throw new ArgumentNullException("user");
            try
            {
                CardNumLocal = Int64.Parse(userInput);
            }
            catch (FormatException formatEx)
            {
                Console.WriteLine(formatEx.Message);
                userInput = Console.ReadLine();
                return parseCard(userInput);
            }
            return userInput;
            }
        }
    }

