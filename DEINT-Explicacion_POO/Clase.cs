using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Explicacion_POO
{
    internal class Clase
    {
        //Campos

        string _nombre = null!;
        int _edad;
        bool _carnet;

        //Propiedades

        public static int Edad { get; set; }
        public string Nombre { get; set; }
        public bool Carnet { get; set; }

        //Metodos

        internal void ImprimirNombre(string s) { 
            Console.WriteLine(s);
        }

        //Constructor ctor
        public Clase()
        {
            
        }

    }
}
