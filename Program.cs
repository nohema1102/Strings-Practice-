using System;
using System.Collections.Generic;

namespace Strings_Practice_
{
    class Program
    {
        static void Main(string[] args)
        {
            string variable = "hola";
            string variable1 = variable.ToUpper();

            Console.WriteLine($"\"{variable}\" -> \"{variable1}\"");

            Console.WriteLine("----------");

            variable = "John, Peter, Charlie";
            string[] variableArray = variable.Split(" ");
            Console.WriteLine(variable);

            Console.WriteLine("----------");

            variable = "Pizza";
            char[] charvariable = variable.ToCharArray();
            Array.Reverse(charvariable);
            variable1 = new string (charvariable);
            Console.WriteLine(variable + " -> " + variable1);

            Console.WriteLine("----------");

            variable = "Tacos > Pizza";
            variable1 = variable.Replace(">", "&gt;");
            Console.WriteLine(variable + " -> " + variable1);

            Console.WriteLine("----------");

            variable = "Pizza < Hamburguesa";
            variable1 = variable.Replace("<", "&lt;");
            Console.WriteLine(variable + " -> " + variable1);

            Console.WriteLine("----------");

            variable = "Azul, Verde, Morado";
            string substringVariable = variable.Substring(13, 6);

            int indexOf = variable.IndexOf("M");
            Console.WriteLine(variable + " -> " + substringVariable);

            Console.WriteLine("----------");

            variable = "ave, banco, comida, duda, ejercicio, fuente, girasol";
            variable1 = variable.ToUpper();
            string variable2 = variable1.Replace(", ", ";");
            variableArray = variable2.Split(";GIRASOL");
            foreach (string value in variableArray)
            {
                Console.WriteLine(variable + " -> " + value );
            }
            

            

        }
    }
}
