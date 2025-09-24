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

        public Szemely(string nev) 
        {
            _nev = nev;
          
        }
        public string Nev
        {   get { return _nev; } 
            set { _nev = value; }
        
        }

        public int Kor
        { 
            get { return _kor; }
            set {
                if (value >= 0)
                    _kor = value;
                else
                    Console.WriteLine("Hibás érték");
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Szemely tanulo1 = new Szemely("Kiss Ilona");
            tanulo1.Kor = 34;
            Console.WriteLine(tanulo1.Nev+tanulo1.Kor);
        }
    }
}
