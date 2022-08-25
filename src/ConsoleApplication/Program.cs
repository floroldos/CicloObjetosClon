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
            /*en este caso se crean tantas instancias en el heap que el destructor empieza a borrar 
            las que no están en uso para liberar espacios de memoria y crear unas nuevas.*/
            for (int i = 0; i < 10000000; i++)
            {
                var Tren = new Train($"Trencito nro {i}");
            }
            Console.WriteLine($"Se crean {Train.Count} instancias de la clase");
            var t1 = new Train( "Last Train To London");
            var t2 = new Train( "Last Train To London");
            var t3 = new Train("Runaway Train");
        }
    }
}