using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEINT_Explicacion_POO
{
    internal class Coche
    {
        public String? Marca { get; set; }
        public Int16 Año { get; set; } = 2020;
        public Int16 Velocidad { get; set; } = 0;
        public Int16 VelocidadMaxima { get; init; } = 120;

        public Coche()
        {

        }

        public Coche(String marca)
        {
            Marca = marca;
        }

        public void Acelerar() {
            Acelerar(1);
        }

        public void Acelerar(Int16 incremento) {
            if (Velocidad + incremento > VelocidadMaxima)
            {
                Console.WriteLine("Supera la velocidad máxima");
            }
            else {
                Int16 temp = Velocidad += incremento;
                Console.WriteLine("Velocidad actual: " + temp);
            }
            
        }

        public void Detener() => Velocidad = 0;

    }
}
