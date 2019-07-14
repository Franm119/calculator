using System;

namespace calculator
{
    /// <summary>
    /// La principal clase de Calculator.
    /// Contiene el método para realizar cálculos de Suma, Resta, Multiplicación y División.
    /// </summary>
    /// <remarks>
    /// Controlará la mayor parte del trabajo de cálculo.
    /// </remarks>
    class calculator
    {
        /// <summary>
        /// Operaciones de dos número de doble precisión y retorna el resultado.
        /// Según la opción seleccionada nos mostrará una sumar, restar, multiplicar o dividir.
        /// Controlará la mayor parte del trabajo de cálculo.
        /// </summary>
        /// <param name="num1">Un número de doble precisión.</param>
        /// <param name="num2">Un número de doble precisión.</param>
        /// <param name="op">Carácter de la operación que se desea realizar.</param>        
        /// <param name="result">Representa un valor que no es un número.</param>
        /// <returns>
        /// Retorna según la opción una suma, resta, multiplicación o división.
        /// </returns> 
        public static double DoOperation(double num1, double num2, string op)
        {
            // Representa un valor que no es un número, que utilizamos si una operación, como la división, podría generar un error.
            double result = double.NaN; 
            // Según la  opción se realizará el cálculo matemático.
            switch (op)
            {
                case "s":
                    result = num1 + num2;
                    break;
                case "r":
                    result = num1 - num2;
                    break;
                case "m":
                    result = num1 * num2;
                    break;
                case "d":
                    // Se solicita alusuario que ingrese un divisor que no sea cero.
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    break;
                // Devuelve texto si la opción es incorrecta.
                default:
                    break;
            }
            return result;
        }
    }

    /// <summary>
    /// La principal clase de Calculator.
    /// Contiene el método para realizar cálculos de Suma, Resta, Multiplicación y División.
    /// </summary>
    /// <remarks>
    /// Esta clase puede sumar, restar, multiplicar y dividir.
    /// controlará la interfaz de usuario y el trabajo de captura de errores.
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Controlará la interfaz de usuario y el trabajo de captura de errores..    
        /// </summary>
        /// <param name="endApp">Bool con valor false.</param>
        /// <param name="numInput1">String vacio.</param>
        /// <param name="numInput2">String vacio.</param>
        /// <param name="result">Double con valor cero.</param>
        /// <param name="cleanNum1">Double con valor cero.</param>
        /// <param name="cleanNum2">Double con valor cero.</param>
        /// <param name="op">Carácter de la operación que se desea realizar.</param>
        /// <returns>
        /// La suma de dos decimales.
        /// La resta de dos decimales.
        /// La multiplicación de dos decimales.
        /// La división de dos decimales.
        /// </returns> 
        /// <typeparam name="Console.WriteLine()">Escribe un texto en pantalla y avanza de línea</typeparam>
        /// <typeparam name="Convert.ToInt32()">Para convertir un valor especificado en un entero con signo de 32 bits.</typeparam>
        /// <typeparam name="Console.ReadLine()">Capturar el dato introducido por el usuario.</typeparam>
        /// <typeparam name="Write()">Escribe lo que sea sin añadir el carácter de fin de línea a la cadena.</typeparam> 
        /// <typeparam name="double.TryParse()">Convierte la representación de cadena de un número en su equivalente de punto flotante de precisión doble.</typeparam> 
        /// <typeparam name="calculator.DoOperation()">Se utiliza para realizar la operación. El resultado de los cálculos se escribe en la variable de result.</typeparam>         
        /// <typeparam name="double.IsNaN()">Verificar si el valor especificado no es un número.</typeparam>         
        
        static void Main(string[] args)
        {
            bool endApp = false;
            // Mostrar título de la aplicación calculator de consola C#
            Console.WriteLine("Calculadora de consola en C#\r");
            Console.WriteLine("----------------------------\n");

            while (!endApp)
            {
                // Declare variables and set to empty
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Solicimos al usuario que ingrese el primer número.
                Console.Write("Escriba un número y luego presione Intro: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("Esta entrada no es válida. Por favor ingrese un valor entero: ");
                    numInput1 = Console.ReadLine();
                }

                // Solicimos al usuario que ingrese el segundo número.
                Console.Write("Escriba otro número y luego presione Intro: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("Esta entrada no es válida. Por favor ingrese un valor entero: ");
                    numInput2 = Console.ReadLine();
                }

                // Pedimos al usuario que elija una opción.
                Console.WriteLine("Elija una opción de la siguiente lista:");
                Console.WriteLine("\ts - Suma");
                Console.WriteLine("\tr - Resta");
                Console.WriteLine("\tm - Multiplicación");
                Console.WriteLine("\td - División");
                Console.Write("Tu opcion? ");

                string op = Console.ReadLine();

                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Esta operación dará como resultado un error matemático.\n");
                    }
                    else Console.WriteLine("Tu resultado: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("¡Oh no! Se produjo una excepción al tratar de hacer los cálculos..\n - Detalles: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Espera a que el usuario responda antes de cerrar.
                Console.Write("Presione 'n' e Intro para cerrar la aplicación, o presione cualquier otra tecla e Intro para continuar: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Interlineado amistoso
            }
            return;
        }
    }
}