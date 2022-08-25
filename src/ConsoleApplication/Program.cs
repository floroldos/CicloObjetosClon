//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            /*en el caso de 10.000.000, se crean tantas instancias en el heap que el destructor empieza a borrar 
            las que no están en uso para liberar espacios de memoria y crear unas nuevas.*/
            for (int i = 0; i < 100; i++)
            {
                var Tren = new Train($"Trencito nro {i}");
            }
            Console.WriteLine($"Se crean {Train.Count} instancias de la clase");
            var t1 = new Train( "Last Train To London");
            var t2 = new Train( "Last Train To London");
            var t3 = new Train("Runaway Train");
            Console.WriteLine($"¿Es cierto que t1 == t2? --> {t1 == t2}");
            Console.WriteLine($"¿Es cierto que t2 == t3? --> {t2 == t3}");
            /*Como no hay dos o más variables que apuntan al mismo objeto, en ambos casos da False.
            Además, en el caso de t1 y t2, solo comparten el nombre. Nunca las definimos como misma variable (t1 = t2),
            por lo que son distintas e individuales.*/

        }
    }
}