using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Explicacion_POO
{
    internal static class ListExtendido
    {
        internal static void ImprimirPorPantalla<T>(this List<T> li)
        {
            foreach (var i in li) {
                Console.WriteLine(i);
            }
        }
    }
}
