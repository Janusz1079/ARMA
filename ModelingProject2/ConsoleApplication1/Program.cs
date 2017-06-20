using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Centrala GlowneCentrala = new Centrala();

            Console.WriteLine("Lista dostepnych rozkazow:");
            Console.WriteLine(GlowneCentrala.Lista_Dostepnych_Rozkazow());
            Console.WriteLine("Wpisz nazwe Rozkazu:");

            while (true)
            {
                string Nazwa_Rozkazu = Console.ReadLine();

                if (Nazwa_Rozkazu == "exit")
                {
                    break;
                }

                GlowneCentrala.WydajRozkaz(Nazwa_Rozkazu);

            }
        }
    }
}
