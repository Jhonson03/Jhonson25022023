using AsincronaS5.Entidades;
using AsincronaS5.Negocio;

Datos dat = new Datos();
ClsDatos clsDatos = new ClsDatos();

Console.Write(@"Bienvenido al mostrador de numeros pares

Por favor ingrese el valor inicial: ");

dat.inicio = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIngrese el valor final: ");
dat.fin = Convert.ToInt32(Console.ReadLine());

Console.Write($"\nLos números pares son: {clsDatos.Contador(dat)}");
