using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Consola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Mini Calculadora - Angel Luis Saorin Faura"; //Sirve para agregarle un titulo a la ventana
            string resp = "";
            do
            {
                int num1 = 0; //Aqui se almacenara el primer valor ingresado.
                int num2 = 0; //Aqui se almacenara el segundo valor ingresado.
                int resultado = 0; //Aqui se almacenara el resultado de la operacion.

                //Aqui mostraremos los mensajes que apareceran en nuestra consola igual que el menu de seleccion.
                Console.WriteLine("Presione el simbolo para realizar la operacion:\n");
                Console.WriteLine("\n+ para sumar");
                Console.WriteLine("- para restar");
                Console.WriteLine("* para multiplicar");
                Console.WriteLine("/ para dividir\n");
                Console.Write("Eliga Una Opcion: "); //Aqui es donde indicaremos que operacion vamos a realizar
                resp = Console.ReadLine();
                string eleccion = Convert.ToString(resp);
                //Aqui se agregaran los mensajes para poder ingresar los datos.
                Console.WriteLine("\nIntroduzca los valores del calculo");
                Console.Write("\nPrimer Valor: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Segundo Valor: ");
                num2 = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (eleccion)
                {
                    case "+":
                        Console.WriteLine("El resultado de la suma es:");
                        resultado = num1 + num2;
                        Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
                        break;
                    case "-":
                        Console.WriteLine("El resultado de la resta es:");
                        resultado = num1 - num2;
                        Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);
                        break;
                    case "*":
                        Console.WriteLine("El resultado de la multiplicacion es:");
                        resultado = num1 * num2;
                        Console.WriteLine("{0} * {1} = {2}", num1, num2, resultado);
                        break;
                    case "/":
                        Console.WriteLine("El resultado de la division es:");
                        resultado = num1 / num2;
                        Console.WriteLine("{0} / {1} = {2}", num1, num2, resultado);
                        break;
                }
                Console.Write("\n¿Desea Continuar? s/n: "); //Si para realizarlo de nuevo y no para salir.
                resp = Console.ReadLine();
            }
            while (resp == "s" || resp == "s");
        }
    }
}
