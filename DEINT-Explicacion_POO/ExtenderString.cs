using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Explicacion_POO
{
    internal static class ExtenderString 
    {
        //Con this y nombre del objeto le indicamos donde lo queremos agregar
        internal static void ImprimirPorPantalla(this string? s, String hola) {
            Console.WriteLine(s + hola);
        }
    }
}
