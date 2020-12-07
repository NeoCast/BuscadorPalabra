using System;
using System.Text.RegularExpressions;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var programa = new Program();
            Console.WriteLine("Escriba una cadena:");
            var entrada = Console.ReadLine();
            programa.mostrarCadena(entrada);
        }

        public string mostrarCadena(string cadena)
        {

           
            string[] palabras = cadena.Split(' ');
            int total;
            Array.Sort(palabras);
            foreach (var palabra in palabras)
            {
                total = Regex.Matches(cadena, palabra).Count;
                System.Console.WriteLine($"Palabra: <{palabra}>, cantidad que repite: {total}");
            }
            return "";

        }


    }
}
