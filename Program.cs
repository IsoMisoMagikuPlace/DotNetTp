using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Hacer un programa de consola en .net que resuelva cada uno de los siguientes enuncuados

            ////1 Realizar un programa de consola que permita ingresar el nombre y apellido por separado, con estos datos debe imprimir un mensaje con el nombre completo.
            //Console.WriteLine("Ingrese un nombre");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese un apellido");
            //string apellido = Console.ReadLine();
            //Console.WriteLine("Nombre y apellido : " + nombre + " " + apellido);
            //Console.Read();

            //2 Realizar un programa de consola que permita ingresar el nombre y la edad, con estos datos debe imprimir un mensaje diciendo si es mayor de edad o no.
            //Console.WriteLine("Ingrese un nombre: ");
            //string nombre = Console.ReadLine();
            //Console.WriteLine("Ingrese una edad: ");
            //int edad = Console.Read();
            //bool mayoriadeedad = int.TryParse(Console.ReadLine(), out edad);

            //if (mayoriadeedad)
            //{
            //    Console.WriteLine(edad > 18 ? "Es menor de edad" : "Es mayor de edad");
            //}
            //Console.Read();

            ////3 Realizar un programa de consola que permita ingresar un numero y calcule la suma de todos los numeros enteros anteriores
            //Console.WriteLine("Ingresar cantidad de numeros a sumar: ");
            //int numerosIngresados = Convert.ToInt32(Console.ReadLine());
            //int sumatoria = 0;

            //for (int i = 1; i <= numerosIngresados; i++)
            //{
            //    Console.WriteLine("Ingresar un numero: ");
            //    int numeroIngresado = Convert.ToInt32(Console.ReadLine()); //esto devuelve un string. usamos el convert para que convierta esa string en int pregunta porque 32? porque es un entero de 32 bit. maximo 2.147m :)

            //    sumatoria = sumatoria + numeroIngresado;
            //}

            //Console.WriteLine("La sumatoria de los numeros ingresados es: " + sumatoria);
            //Console.Read();

            ////4 Realizar un programa de consola que permita ingresar 2 valores y encuentr el maximo comun divisor
            //Console.WriteLine("Ingresar primer numero: ");
            //int numeroPrimero = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ingresar segundo numero:");
            //int numeroSegundo = Convert.ToInt32(Console.ReadLine());
            //int divisor = numeroPrimero > numeroSegundo ? numeroSegundo : numeroPrimero;

            //while (numeroPrimero % divisor != 0 || numeroSegundo % divisor != 0)
            //{
            //    divisor--;
            //}

            //Console.WriteLine("Divisor: " + divisor);
            //Console.Read();

            ////5 Realizar un programa de consola que permita ingresar numeros y que termine de pedir numeros cuando se ingresa 0 y calcule el promedio de todos los ingresados
            //int contador = 0;
            //int sumatoriaTotal = 0;
            //int numero;

            //do
            //{
            //    Console.WriteLine("Ingresar numero");
            //    numero = Convert.ToInt32(Console.ReadLine());
            //    if (numero != 0)
            //    {
            //        sumatoriaTotal += numero;
            //        contador++;
            //    }
            //} while (numero != 0);

            //int promedioTotal = sumatoriaTotal / contador;
            //Console.WriteLine("El promedio total es de: " + promedioTotal);

            //Console.Read();
        }
    }
}
