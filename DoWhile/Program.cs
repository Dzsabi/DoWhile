using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {

        static void Koszon()
        {
            Console.WriteLine("Szia!");
        }
        static void Koszon(string nev)
        {
            Console.WriteLine($"Szia {nev}!");
        }
        static void Bemutatkozas(string nev, int eletkor)
        {
            Console.WriteLine($"Szia {nev}, {eletkor} éves vagyok!");
        }



        static int Osszeadas(int szam1, int szam2)
        {
            return szam1 + szam2;
        }

        static int Kivonas(int szam1, int szam2)
        {
            if (szam1 > szam2)
                return szam1 - szam2;
            else
                return szam2 - szam1;
        }

        static int Szorzas(int szam1, int szam2)
        {
            return szam1 * szam2;
        }

        static int Osztas(int szam1, int szam2)
        {
            return szam1 / szam2;
        }

        static bool Nagykoru(int kor)
        {
            if (kor >= 18)
                return true;
            else
                return false;
        }



        static void Main(string[] args)
        {
            /*
            Koszon();

            Console.Write("Adj meg a neved: ");
            string nev = Console.ReadLine();

            Console.Write("Adj meg az áletkorod: ");
            int kor = Convert.ToInt32(Console.ReadLine());
            Bemutatkozas(nev, kor);
            int osszeg = Osszeg(5, 10);
            Console.WriteLine(osszeg);
            Console.WriteLine(Osszeg(5, 10));
            




        Console.WriteLine("Első szám: ");
            int szam1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Második szám: ");
            int szam2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Osszeadas: {Osszeadas(szam1, szam2)}");
            Console.WriteLine($"Kivonas: {Kivonas(szam1, szam2)}");
            Console.WriteLine($"Szorzas: {Szorzas(szam1, szam2)}");
            Console.WriteLine($"Osztas: {Osztas(szam1, szam2)}");


            string nagykoru = "";
            if (Nagykoru(20))
                nagykoru = "Felnőtt";
            else
                nagykoru = "Nem felnőtt";
            Console.WriteLine($"A te életszakaszod: {nagykoru}");

      

            Console.ReadLine();
            */

            int szam = 1;
            do
            {
                Console.WriteLine(szam);
                szam++;

            } while (szam <= 10);


            int valasztas;
            do
            {
                Console.Clear();
                Console.WriteLine("===MENU===");
                Console.WriteLine("1. Koszon");
                Console.WriteLine("1. Nev");
                Console.WriteLine("1. Kilep");
                Console.Write("Valassz: ");
                valasztas = Convert.ToInt32(Console.ReadLine());

                switch (valasztas)
                {
                    case 1:
                        Koszon();
                        break;
                    case 2:
                        Console.Write("Add meg a neved: ");
                        string nev = Console.ReadLine();
                        Koszon(nev);
                        break;
                    case 3:
                        Console.WriteLine("Viszlát!");
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("Hibás választás!");
                        Console.ReadLine();
                        break;
                }
            } while (valasztas != 3);




        }
    }
}

