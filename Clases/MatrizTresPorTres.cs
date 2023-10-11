using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica3_JSVE.Clases
{
    internal class MatrizTresPorTres
    {
        public void Ejercicio1()
        {
            int[,] matriz = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Los valores del 1 al 9:");


            for (int fila = 0; fila < 3; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.WriteLine(matriz[fila, columna] + " ");
                }
                Console.WriteLine();
            }
        }


        //En el ejercicio 2 fué basicamente reutiliar el codigo anterior solo cambiarle el valor a la fila y a la columna y volver la matriz un string para ponerle los colores.
        //PD: Así fué con los demas y basandome con el powerpoint.
        public void Ejercicio2()
        {
            string [,] matriz2 = { { "Rojo", "Verde" }, { "Azul", "Amarillo " } };
            Console.WriteLine("Colores de 2x2:");


            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 2; columna++)
                {
                    Console.WriteLine(matriz2[fila, columna] + " ");
                }
                Console.WriteLine();
            }
        }

        public void Ejercicio3()
        {
            double[][] escalonada =
            {
                new double[] { 1.1, 2.2, 3.3 },
                new double[] { 4.4, 5.5, 6.6, 7.7 },
                new double[] { 8.8, 9.9, 10.10 },
                new double[] { 11.11, 12.12, 13.13 }
            };


            double suma = 0.0;
            Console.WriteLine("Matriz de números 4x3:");

            for (int fila = 0; fila < 4; fila++)
            {
                for (int columna = 0; columna < 3; columna++)
                {
                    Console.Write(escalonada[fila][columna] + " ");
                    suma += escalonada[fila][columna];
                }
                Console.WriteLine();
            }

            Console.WriteLine("La suma de los elementos del arreglo: " + suma);
        }

        public void Ejercicio4()
        {
            char[,] matriz4 = new char[2, 4]
            {{ 'A', 'B', 'C', 'D' }, { 'E', 'F', 'G', 'H' }};

            Console.WriteLine("Matriz de 2x4:");
            for (int fila = 0; fila < 2; fila++)
            {
                for (int columna = 0; columna < 4; columna++)
                {
                    Console.WriteLine(matriz4[fila, columna] + " "); 
                    
                }
                Console.WriteLine();
            }
        }
    }
}
