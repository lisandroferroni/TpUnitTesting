using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Program
    {

        static void Main(string[] args)
        {
            Rectangulo seba = new Rectangulo(10, 15);
            System.Console.WriteLine(seba.Bas+" es el perimetro");
            System.Console.ReadKey();
        }
    }
    public class Rectangulo
    {
        private int _Bas, _Altura;
        public int Bas {
            set
            {
                _Bas = value;
            }
            get
            {
                return _Bas;
            }
        }
        public int Altura
        {
            set
            {
                _Altura = value;
            }
            get
            {
                return _Altura;
            }
        }
        public Rectangulo(int b,int a)
        {
            Bas = b;
            Altura = a;
        }
        public int Perimetro()
        {
            return (Bas*2+Altura*2);
        }
        public int Area ()
        {
            return (Bas * Altura);
        }
    }
}
