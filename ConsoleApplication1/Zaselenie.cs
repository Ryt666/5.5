using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gostinica_nr_5._8_
{
    class zaselenie
    {
        public delegate void MethodUslugi();

        public event MethodUslugi GoUslugi_V;
        public event MethodUslugi GoUslugi_E;

        public void bron()
        {
            string Stoimost = "";
            string str = "";
            var lines = new List<string> { };
            lines.Add("заселение ");
            //int index = 0;
            Console.WriteLine(" 1 - забронировать номер \n 2 - заселение \n ");
            string s = Console.ReadLine();
            int moj_vybor = int.Parse(s);

            switch (moj_vybor)
            {
                case 1:
                    Console.WriteLine("Желаемая дата заселения: ");
                    string number = Console.ReadLine();
                    lines.Add(number);
                    Console.WriteLine("Выберите номер: номер эконом-класса(введите econom) или номер для VIP (введите vip):");
                    string vybor = Console.ReadLine();
                    lines.Add(vybor);
                    if (vybor == "econom")
                    {
                        Console.WriteLine("Стоимость проживания за 1 сутки - 20$ \n Введите количество суток проживания: ");
                        str = Console.ReadLine();
                        int sutki = int.Parse(str);
                        int stoimost = sutki * 20;
                        Stoimost = stoimost.ToString();
                        Console.WriteLine("Итого {0}$ \n  ", stoimost);
                        Console.WriteLine(" Счёт вашей кредитной карты или банковский счёт: ");
                        string s1 = Console.ReadLine();

                        GoUslugi_E();
                    }
                    else if (vybor == "vip")
                    {
                        //index = 1;
                        Console.WriteLine("Стоимость проживания за 1 сутки - 50$ \n Введите количество суток проживания: ");
                        str = Console.ReadLine();
                        int sutki = int.Parse(str);
                        int stoimost = sutki * 50;
                        Stoimost = stoimost.ToString();
                        Console.WriteLine("Итого {0}$ \n ", stoimost);
                        Console.WriteLine(" Счёт вашей кредитной карты или банковский счёт: ");
                        string s1 = Console.ReadLine();

                        GoUslugi_V();
                    }
                    Console.WriteLine(" Операция бронировки прошла успешно. Благодарим за Ваш выбор.");
                    break;

                case 2:
                    Console.WriteLine(" На данный момент свободен номер эконом-класса. стоимость за 1 сутки - 20 $ \n Введите количество суток проживания: ");
                    str = Console.ReadLine();
                    int sutki1 = int.Parse(str);
                    int stoimost1 = sutki1 * 20;
                    Stoimost = stoimost1.ToString();
                    Console.WriteLine("Итого {0}$ \n ", stoimost1);
                    Console.WriteLine(" Счёт вашей кредитной карты или банковский счёт: ");
                    string s2 = Console.ReadLine();
                    Console.WriteLine(" Благодарим за Ваш выбор. Можете пройти в номер. ");

                    GoUslugi_E();

                    break;
            }
            lines.Add("Количество суток проживания: ");
            lines.Add(str);
            lines.Add("Итого: ");
            lines.Add(Stoimost);
            lines.Add("Оплачено.");
            
        }
    }
}
