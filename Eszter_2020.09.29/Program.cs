using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Eszter_2020._09._29
{
    class Program
    {
        static void Main(string[] args)
        {
            //19. Olvass be egy mondatot, és írd ki a szavait egymás alá. 
            //(A szavakat egymástól a szóköz karakter választja el.)
            string mondat = "Olvass be egy mondatot, és írd ki a szavait egymás alá.";
            string[] szavak = mondat.Split(' ');
            int n = 0;
            while (n < szavak.Length)
            {
                Console.WriteLine(szavak[n]);
                n++;
            }

            for (int i = 0; i < szavak.Length; i++)
            {
                Console.WriteLine($"{szavak[i]} ");
            }
            //strinToCharacter
            string szo = "valami";
            char[] kartomb = szo.ToCharArray();
            foreach (var j in kartomb)
            {
                Console.WriteLine(j.ToString());
            }
            //int egyik = 3;
            Console.WriteLine($"A függvényben megírt két szám összege: {Ket_szam_osszead()}");
            Console.Write("Kérem adjon meg egy számot: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Kérem adjon meg egy másik számot: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A paraméterezett függvény értéke, melyet már a felhasználó ad meg: {Ket_szam_osszead_parameterekkel(a, b)}");
            Vonalhuz();
            Console.WriteLine();
            Vonalhuz_karakterrel('_');
            Console.WriteLine($"\nA három szám szorzata:{szamok_osszeszorzasa(a, b, 20)} ");
            Vonalhuz();
            Console.WriteLine();//üres sor
            char kar = '*';
            Vonalhuz_karakterrel(kar);
            Console.ReadKey();
        }
        //Példa
        static int Ket_szam_osszead()
        {
            int egyik = 3;
            int masik = 4;
            //int osszeg = egyik + masik;
            return egyik + masik;
        }

        //Ez egy másik függvény, de paramétert is tartalmaz!
        static int Ket_szam_osszead_parameterekkel(int egyik, int masik)
        {
            return egyik + masik;
        }

        //Írj függvényt, amely három egész számot összeszoroz, majd visszatér az értékével!
        static long szamok_osszeszorzasa(int egyik, int masik, int harmadik)
        {
            return egyik * masik * harmadik;
        }

        //Írj függvényt amely a másodfokú egyenlet "a,b,c" változóira megadja a függvény "x1 és x2" értékét.
        static double Megoldokeplet(int a, int b, int c)
        {
            int gyokalatt = b * b - 4 * a * c;
            if (gyokalatt < 0)
            {
                Console.WriteLine("Az egyenletnek nincs megoldása!");
                return 0;
            }
            else if (gyokalatt == 0)
            {
                double ertek = -b / 2 * a;
                return ertek;
            }
            else
            {
                double x1 = -b + (Math.Sqrt(gyokalatt) / 2 * a);
                double x2 = -b - (Math.Sqrt(gyokalatt) / 2 * a);
                Console.WriteLine($"x1 értéke: {x1}");
                Console.WriteLine($"x2 értéke: {x2}");
                return 0;
            }
        }

        //Eljárásra egyszerű példa
        static void Vonalhuz()
        {
            for (int i = 1;i<41;i++)
            {
                Console.Write("-");
            }        
        }

        //Eljárásra egyszerű példa paraméterrel
        static void Vonalhuz_karakterrel(char kar)
        {
            for (int i = 1;i<41;i++)
            {
                Console.Write(kar);
            }
        }

        //Fontos szabály(ok) paraméterezett függvény létrehozásakor:
        //1. szabály: a paraméterben megadott érték, vagy változónak minden esetben meg kell adni a típusát.
        //2. szabály: akárhány paramétere lehet a függvénynek.
        //3. szabály: a paramétereket egymástól vesszővel válasszuk el.

        //Függvény
        //1.szabály: az osztályon belűl, de a main-en kívűl hozzuk létre.
        //2. szabály: felépítése
        //-láthatóság:  public /Minden osztályból látható
        //              static /Csak az osztályban látható, ahol a main is van!
        //              protected /védett
        //              private /személyes
        //3. szabály: a függvény visszatérési értékének a típusát kell mgadni.
        //4. szabály: a függvénynek a neve.
        //5. szabály: mindenképpen paramétert tartalmaz, de lehet üres is.
        //6. szabály: kötelezően tartalmaznia kell a "return" kulcsszót.

        //Eljárás szabályai:
        //1.szabály: az osztályon belűl, de a main-en kívűl hozzuk létre.
        //2. szabály: felépítése
        //-láthatóság:  public /Minden osztályból látható
        //              static /Csak az osztályban látható, ahol a main is van!
        //              protected /védett
        //              private /személyes
        //Az eljárásnak nincs visszatérési értéke (Nincs "return")
        //Az eljárásban kötelezően szerepelnie kell a "void" kulcsszónak.
        //Az eljárásnak van neve (Nem lehet foglalt szó, kulcsszó)
        //Mindenképpen paramétert tartalmaz, de lehet üres is.
        //Ha paramétert adunk annyi paraméterrel kell meghívni, ahány paramétert adtunk a megírásakor.

        //Fontos szabály(ok) paraméterezett eljárás létrehozásakor:
        //1. szabály: a paraméterben megadott érték, vagy változónak minden esetben meg kell adni a típusát.
        //2. szabály: akárhány paramétere lehet az eljárásnak.
        //3. szabály: a paramétereket egymástól vesszővel válasszuk el.
    }
}
