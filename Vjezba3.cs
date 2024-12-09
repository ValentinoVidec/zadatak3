using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace vjezba1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PublicKey class Neboder
        {
            private double visina;
            private int brojKatova;
            public double Visina
            {
                get { return visina; }
                set { visina = value; }
            }
            public int BrojKatova
            {
                get { return brojKatova; }
                set { brojKatova = value; }
            }
            public Neboder(double visina, int brojKatova)
            {
                this.visina = visina;
                this.brojKatova = brojKatova;
            }
            public override string ToString()
            {
                return $"Neboder: Visina = {visina} m, Broj katova = {brojKatova}, Prosječna visina kata = {visina / brojKatova} m";
            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Neboder Tower = new Neboder(200, 100);
                Tower.Visina += 10;
                Tower.BrojKatova += 1;
                Console.WriteLine(Tower.ToString());
            }
        }
    }
}
