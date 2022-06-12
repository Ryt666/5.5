using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace gostinica_nr_5._8_
{
    class Program
    {
        static void Main(string[] args)
        {
            zaselenie Z = new zaselenie();
            ProziwanieEconom E = new ProziwanieEconom();
            ProziwanieVIP V = new ProziwanieVIP();

            Z.GoUslugi_E += E.uslugi;
            Z.GoUslugi_V += V.uslugi;

            Z.bron();

            Console.ReadKey();
        }
    }
}