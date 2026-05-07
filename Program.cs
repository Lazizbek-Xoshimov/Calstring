using System;

namespace Calstring
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string inputUser = string.Empty;
            do
            {
                Console.WriteLine("Hisoblamoqchi bo'lgan qo'shish va ayirish amallarini kiriting.");
                Console.Write("(Izoh. Faqat a+b-c-d... ketma-ketligida kiriting): ");

                string action = Console.ReadLine();

                int count = 0;
                int summa = 0;
                string number = "0";
                char sign = '+';

                while (count <= action.Length)
                {
                    if (count == action.Length || action[count] == '+' || action[count] == '-')
                    {
                        switch (sign)
                        {
                            case '+':
                                {
                                    summa += int.Parse(number);
                                    break;
                                }
                            case '-':
                                {
                                    summa -= int.Parse(number);
                                    break;
                                }
                        }

                        if (count < action.Length)
                            sign = action[count];

                        number = "";
                    }
                    else
                    {
                        number += action[count];
                    }

                    count ++;
                }

                Console.WriteLine(action + "=" + summa);
                Console.WriteLine("Dasturdan chiqishni xohlaysizmi?");
                Console.Write("(ha/yo'q): ");
                inputUser = Console.ReadLine();
            } while (inputUser.ToLower() == "yo'q");
        }
    }
}