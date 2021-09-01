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
            var train = new Train("1");
            ///train.StartEngines();
            ///var train2 = new Train("2");
            ///var train3 = new Train("3");
            Console.WriteLine(Train.Count - 1);
            for(int i = 0; i < 100; i++)/// se puede poner 10.000.000 si se quiere
            {
                train = new Train($" Tren: {i}");
            }
            Console.WriteLine(Train.Count - 1);

            var t1 = new Train("Last Train To London");
            var t2 = new Train("Last Train To London");
            var t3 = new Train("Runaway Train");
            Console.WriteLine(t1==t2);
            Console.WriteLine(t2==t3);
            /// t1 == t2, t2 == t3, son falsas porque ambas son distintos objetos, mas alla que algunos tengan los mismos parametros, para c# opupan memoria por separado.
        }
    }
}