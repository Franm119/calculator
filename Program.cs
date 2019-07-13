using System;

namespace calculator
{
    /// <summary>
    /// La principal clase de Calculator.
    /// Contiene el método para realizar cálculos de Suma, Resta, Multiplicación y División.
    /// </summary>
    /// <remarks>
    /// Esta clase puede sumar, restar, multiplicar y dividir.
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Agrega dos enteros y devuelve el resultado según la opción seleccionada.    
        /// </summary>
        /// <param name="num1">Varible inicializadas a cero.</param>
        /// <param name="num2">Varible inicializadas a cero.</param>
        /// <typeparam name="Console.WriteLine()">Escribe un texto en pantalla y avanza de línea</typeparam>
        /// <typeparam name="Convert.ToDouble()">Para convertir un valor especificado en un entero con signo de 32 bits.</typeparam>
        /// <typeparam name="Console.ReadLine()">Capturar el dato introducido por el usuario.</typeparam>
        /// <typeparam name="Write()">Escribe lo que sea sin añadir el carácter de fin de línea a la cadena.</typeparam> 
        /// <typeparam name="Console.ReadKey()">Obtiene la siguiente tecla pulsada por el usuario.</typeparam>
        static void Main(string[] args)
        {
            // Declarar variables y luego inicializadas a cero.
            double num1 = 0; double num2 = 0;

            // Mostrar título de la aplicación calculator de consola C#
            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("----------------------------\n");

            // Solicimos al usuario que ingrese el primer número.
            Console.WriteLine("Escriba un número y presione Intro");
            num1 = Convert.ToDouble(Console.ReadLine());

            // Solicimos al usuario que ingrese el segundo número.
            Console.WriteLine("Escriba otro número y presione Intro");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Pedimos al usuario que elija una opción.
            Console.WriteLine("Elija una opción de la siguiente lista:");
            Console.WriteLine("\ts - Suma");
            Console.WriteLine("\tr - Resta");
            Console.WriteLine("\tm - Multiplicación");
            Console.WriteLine("\td - División");
            Console.Write("Tu opcion? ");

            // Usamos la instrucción switch para hacer los cálculos
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Tu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "r":
                    Console.WriteLine($"Tu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Tu resultado: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"Tu resultado: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            // Esperamos a que el usuario responda antes de cerrar
            Console.Write("Presiona cualquier tecla para cerrar la aplicación de la consola Calculadora...");
            Console.ReadKey();
        }
    }
}
