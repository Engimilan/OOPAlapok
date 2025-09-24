using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOAlapok
{
    public class Szemely
    {
        private string _nev;
        private int _kor;

        public Szemely(string nev, int kor) 
        {
            _nev = nev;
            _kor = kor;
        }
        public string Kiir()
        { 
            return _nev+_kor;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Kiss Ilona", 44);
            Console.WriteLine(tanulo1.Kiir());
        }
    }
}
