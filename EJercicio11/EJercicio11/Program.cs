using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Una manera de representar números grandes es mediante arreglos unidimensionales, de esta
                forma se pueden representar números enteros que sobrepasen el rango de los long, de esta
                manera el número 789543789543 se puede representar de la siguiente forma.

                7 8 9 5 4 3 7 8 9 5 4 3
                Se pide implementar un programa que permita realizar las siguientes tareas:
                a. Leer un número grande y almacenarlo en un arreglo como el mostrado
                anteriormente.
                b. Mostrar un número grande.
                c. Sumar dos números grandes.
                d. Multiplicar un número grande por un digito.*/

            string aux01, aux02;
            int len01, len02, len;

            do // se pide número 1 como cadena
            {
                Console.Write("ingrese entero 1 [1, 30] dígitos: ");
                aux01 = Console.ReadLine();
                len01 = aux01.Length;
            } while (len01 == 0 && len01 > 30);

            do // se pide número 2 como cadena
            {
                Console.Write("ingrese entero 2 [1, 30] dígitos: ");
                aux02 = Console.ReadLine();
                len02 = aux02.Length;
            } while (len02 == 0 && len02 > 30);

            // se tranforma cadenas a números
            int[] num01 = new int[aux01.Length];
            int[] num02 = new int[aux02.Length];

            for (int i = 0; i < aux01.Length; ++i)
            {
                num01[i] = aux01.ElementAt(i) - 48; // 0 código ASCII 48
            }

            for (int i = 0; i < aux02.Length; ++i)
            {
                num02[i] = aux02.ElementAt(i) - 48;
            }

            len = len01 > len02 ? len01 : len02;

            // sumando
            int[] result = new int[len + 1];
            int def = 0;
            for (int i = len, l1 = len01, l2 = len02; i >= 0; --i, --l1, --l2)
            {
                int dig = 0;

                if (l1 > 0)
                {
                    dig += num01[l1 - 1];
                }

                if (l2 > 0)
                {
                    dig += num02[l2 - 1];
                }

                dig += def;

                result[i] = dig % 10;
                def = dig / 10;
            }

            // impresión
            Console.Write("\n\n     ");
            if (len != len01)
            {
                for (int i = 0; i < (len - len01); ++i)
                {
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < num01.Length; ++i)
            {
                Console.Write(num01[i]);
            }

            Console.Write("\n     ");
            if (len != len02)
            {
                for (int i = 0; i < (len - len02); ++i)
                {
                    Console.Write(" ");
                }
            }

            for (int i = 0; i < num02.Length; ++i)
            {
                Console.Write(num02[i]);
            }

            Console.Write("\n    ");
            for (int i = 0; i <= len; ++i)
            {
                Console.Write("-");
            }

            Console.Write("\n    ");
            for (int i = 0; i < result.Length; ++i)
            {
                if (i == 0 && result[i] == 0)
                {
                    Console.Write(" ");
                    continue;
                }

                Console.Write(result[i]);
            }

            Console.ReadKey();
        }
    }
}
