using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;



namespace alex.Aritmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double valor1 ;
            Console.WriteLine("----CALCULADORA----  ");
            Console.WriteLine("Ingrese un valor : ");
            valor1 = double.Parse(Console.ReadLine());
            var calNet = new Calculadora();
            var resultado =calNet.Sumar (valor1,3);
            resultado=calNet.Restar(resultado,3);
            resultado=calNet.Raiz(resultado);
            resultado=calNet.Dividir(resultado,2);
            resultado=calNet.Multiplicar(resultado,4);
            Console.WriteLine("El resultado de la operacion es : "+ resultado);
            Console.WriteLine("\n\n\tPresione < ENTER > para salir . . .");
            Console.ReadKey();
        }
    }
}
