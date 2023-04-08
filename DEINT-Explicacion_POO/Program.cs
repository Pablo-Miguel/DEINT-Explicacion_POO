// See https://aka.ms/new-console-template for more information

using DEINT_Explicacion_POO;

var x = new Clase();

x.Carnet = false;
Clase.Edad = 7;
x.ImprimirNombre("Hola mundo");

Console.WriteLine(x.Carnet + " " + Clase.Edad);

String cadena = "Hola, ";

cadena.ImprimirPorPantalla("mundo");

List<int> lista = new List<int>() { 0, 1, 32 };
lista.ImprimirPorPantalla();

Coche coche1 = new Coche();
Coche coche2 = new Coche();

//coche1.VelocidadMaxima = 5;

coche1.Velocidad = 4;

coche1.Acelerar();

coche1.Acelerar(23);

coche1.Detener();