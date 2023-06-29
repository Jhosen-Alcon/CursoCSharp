using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hola mundo");
            //Console.ReadKey();

            //Variables
            string nombre = "Juan";
            int edad = 30;
            int edad_siguiente;
            Console.WriteLine("Me llamo " + nombre + " y tengo " + edad + " años ");
            edad_siguiente = edad + 1;
            Console.WriteLine("El año que viene tendré " + edad_siguiente + " años ");
            Console.ReadKey();

            ////Datos
            int numeroEntero = 5;
            double numeroDecimal = 3.14;
            string texto = "Hola";
            char letra = 'A';
            bool variableBool = true;

            //Registro de informacion
            string nombre1 = "Pedro";
            Console.WriteLine("Hola \n mundo ");
            Console.ReadKey();

            //Trabajar con texto
            string texto1 = "Hola";
            string texto2 = " Jhosen";
            string textoresultado = texto1 + texto2;
            Console.WriteLine(textoresultado);
            Console.WriteLine(texto1[0]);
            Console.ReadKey();


            string nombre11 = "Jhosen";
            string apellido = "Alcon";
            string frase = $"Mi nombre es {nombre11} y mi apellido es {apellido}";
            Console.WriteLine(frase.Length);
            Console.WriteLine(frase.ToUpper().Contains("N"));
            Console.WriteLine(frase.IndexOf("J"));
            Console.WriteLine(frase.Substring(10));
            Console.ReadKey();

            //Trabajar con Números
            int numero1 = 10;
            double numero2 = 3.5;
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Pow(2, 5));
            Console.WriteLine(Math.Sqrt(32));
            Console.WriteLine(Math.Round(2.7));
            Console.WriteLine(Math.Ceiling(2.3));
            Console.WriteLine(Math.Floor(2.8));
            Console.WriteLine(Math.Max(10, 15));
            Console.WriteLine(Math.Min(10, 15));
            Console.ReadKey();


            //Solicitar Información del usuario
            Console.Write("Introduce tu nombre: ");
            string nombre12 = Console.ReadLine();
            Console.Write("Introduce tu edad: ");
            int edad12 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bienvenido " + nombre12 + " con la edad de " + edad12);
            Console.ReadKey();


            //Arrays
            string[] nombres = { "Pablo", "Laura", "Jhosen", "Alejandra", "Jherson" };
            double[] notas = { 7.2, 4.8, 8.9, 6.7, 6.6 };
            bool[] aprobado = { true, false, false };
            int[] edades = new int[5];
            edades[0] = 21;
            edades[1] = 22;
            edades[2] = 23;
            edades[3] = 25;
            edades[4] = 27;
            Console.WriteLine(nombres[0]);
            Console.ReadKey();


            //excepciones
            try
            {
                int[] nums = { 1, 2, 3, 4, 5 };
                Console.WriteLine(nums[8]);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();

        }
    }
}
