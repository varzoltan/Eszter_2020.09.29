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
            while (n<szavak.Length)
            {
                Console.WriteLine(szavak[n]);
                n++;
            }

            for (int i=0; i<szavak.Length; i++)
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
            Console.ReadKey();
        }

        //1.szabály: az osztályon belűl, de a main-en kívűl hozzuk létre.
        //2. szabály: felépítése
        //-láthatóság:  public /Minden osztályból látható
        //              static /Csak az osztályban látható, ahol a main is van!
        //              protected /védett
        //              private /személyes
        //3. szabály: a függvény visszatérési értékének a típusát kell mgadni.
        //4. szabály: a függvénynek a neve.
        //5. szabály: mindenképpen paramétert tartalmaz, de lehet üres is.
    }
}
