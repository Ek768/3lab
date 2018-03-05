using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Nomenklatura skripka_nomenklatura = new Nomenklatura("skripka", new DateTime(2018, 01, 28));
            Nomenklatura gitara_nomenklatura = new Nomenklatura("gitara", new DateTime(2018, 02, 05));
            Tovar skripka1 = new Tovar(skripka_nomenklatura, 6000);
            Tovar skripka2 = new Tovar(skripka_nomenklatura, 7000);
            Tovar gitara1 = new Tovar(gitara_nomenklatura, 15000);
            Tovar gitara2 = new Tovar(gitara_nomenklatura, 20000);

            skripka1.Get_info();
            skripka2.Get_info();
            gitara1.Get_info();
            gitara2.Get_info();
            Console.ReadLine();

        }
    }
}









       
