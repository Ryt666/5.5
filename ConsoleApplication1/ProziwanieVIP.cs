using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gostinica_nr_5._8_
{
    class ProziwanieVIP
    {
        public void uslugi()
        {
            var lines1 = new List<string> { "Услуги:" };
            int cena = 0;
            int num = 0;
            while (num == 0)
            {
                Console.WriteLine(" Выберите услугу: \n 1 уборка  \n 2 смена постельного белья \n 3 завтрак в номер \n 4 коктель-бар(только для вип) \n 5 сейф (только для вип) \n 6 выселение \n");
                string s = Console.ReadLine();
                int moj_vybor = int.Parse(s);

                switch (moj_vybor)
                {
                    case 1:
                        lines1.Add("уборка - 5$");
                        cena = cena + uborka();
                        break;
                    case 2:
                        lines1.Add("смена постельного белья - 2$");
                        cena = cena + smena_postelnogo_belja();
                        break;
                    case 3:
                        lines1.Add("завтрак в номер - 10$");
                        cena = cena + zawtrak_v_nomer();
                        break;
                    case 4:
                        lines1.Add("коктель-бар- 15$");
                        cena = cena + coctail_bar();
                        break;
                    case 5:
                        lines1.Add("сейф-5$");
                        cena = cena + sejf();
                        break;
                    case 6:
                        num = 1;
                        break;
                }

            }

            Console.WriteLine("Итого: {0}$", cena);
            string Cena = cena.ToString();
            lines1.Add("Выселение");
            lines1.Add("Окончательный счёт: ");
            lines1.Add(Cena);
            
        }


        public int uborka()
        {
            int cena1 = 0;
            cena1 = cena1 + 5;
            Console.WriteLine("5$");
            return cena1;
        }

        public int zawtrak_v_nomer()
        {
            int cena3 = 0;
            cena3 = cena3 + 10;
            Console.WriteLine("10$");
            return cena3;
        }

        public int coctail_bar() //для VIP класса
        {
            int cena4 = 0;
            cena4 = cena4 + 15;
            Console.WriteLine("15$");
            return cena4;
        }

        public int sejf() //для VIP класса
        {
            int cena5 = 0;
            cena5 = cena5 + 5;
            Console.WriteLine("5$");
            return cena5;
        }

        public int smena_postelnogo_belja()
        {
            int cena2 = 0;
            cena2 = cena2 + 2;
            Console.WriteLine("2$");
            return 0;
        }
    }
}
