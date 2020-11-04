
using System.Collections;
using System.Globalization;

namespace EjerciciosExamen
{
    class EjerciciosExamenT1
    {
        // 1. Hacer una función que reciba dos enteros y devuelva la suma de esos dos enteros
        public static int AddIntegers(int a, int b)
        {
            return a + b;
        }

        // 2. Hacer una función que reciba dos reales y devuelva la resta de esos dos reales
        public static double SubtractDoubles(double a, double b)
        {
            return a - b;
        }

        // 3. Hacer una función que reciba dos enteros y devuelva el menor de los dos
        public static int LowestNumber(int a, int b)
        {
            if (a < b)
                return a;
            return b;
        }

        // 4. Hacer una función que reciba dos enteros y devuelva si el primero es menor que el segundo
        public static bool IsLower(int a, int b)
        {
            if (a < b)
                return true;
            return false;
            // Alternativa: return a < b;
        }

        // 5. Hacer una función que reciba 3 strings y devuelva la concatenación de los 3
        public static string Concatenacion(string a, string b, string c)
        {
            return a + b + c;
        }

        // 6. Hacer una función que reciba dos enteros y devuelva -1 si el primero es menor que el segudo, +1 si el segundo es menor que el primero, y 0 en cualquier otro caso
        public static int Compare(int a, int b)
        {
            if (a < b)
                return -1;
            if (a > b)
                return 1;
            return 0;

        }
        // 7. Hacer una función que reciba un código de error e imprima por pantalla:
        // "Error crítico" en caso de que el código sea 0
        // "Error leve" en caso de que el código sea 1
        // "Error moderado" en caso de que el código sea 2
        // "Error desconocido" en caso de que el código sea otra cosa
        public static void MensajesError(int code)
        {
            // Hacer un if daría menos nota
            switch (code)
            {
                case 0:
                    System.Console.WriteLine("Error crítico.");
                    break;
                case 1:
                    System.Console.WriteLine("Error leve.");
                    break;
                case 2:
                    System.Console.WriteLine("Error moderado.");
                    break;
                default:
                    System.Console.WriteLine("Error desconocido.");
                    break;
            }
        }

        // 8. Hacer una función que se le pase un número y escriba lo siguiente: 0, 3, 6, 9, 12, ... hasta llegar a ese número
        // Por ejemplo: función(10) imprimiría 0, 3, 6, 9.
        public static void PrintSeries(int a)
        {
            int i = 0;
            while (i <= a)
            {
                System.Console.Write(i + ",");
                i+=3;
            }
            System.Console.Write(" ...");
        }

        // 9. Hacer una función que se le pasen 3 enteros y devuelva el menor de los tres.
        public static int MenordeTres(int a, int b, int c)
        {
            // solución óptima
            if (a <= b)
            {
                if (a <= c)
                    return a;
                else
                    return c;
            }
            else
            {
                if (b <= c)
                    return b;
                else
                    return c;
            }
        }

        // 10. Hacer una función que se le pasen 4 enteros y devuelva el menor de los 4.
        public static int MenordeCuatro(int a, int b, int c, int d)
        {
            if (a <= b)
            {
                return MenordeTres(a, b, c);
            }
            else
                return MenordeTres(b, c, d);
            // Otra opción
            // int num = MenordeTres(a, b, c);
            // if (num < d)
            //     return num;
            // else
            //     return d;
        }

        // 11. Hacer una función que se le pase un entero e imprima por pantalla las siguientes series de ejemplo:
        // Serie (10) -> 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
        // Serie (3) -> 0, 1, 2,
        public static void ImprimeSerie(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write(i + ", ");
        }

        // 12. Igual que el 11 pero quitando la última coma
        public static void ImprimeSerie2(int n)
        {
            if (n > 0)
                System.Console.Write(0);
            for (int i = 0; i < n; i++)
                System.Console.Write(", " + i);
        }

        // 13. Hacer una función que se le pase un entero e imprima una línea de tantos asteriscos como ese nº
        public static void ImprimirAsteriscos(int n)
        {
            for (int i = 0; i < n; i++)
                System.Console.Write("*");
        }

        // 14. Hacer una función que se le pase un entero e imprima el siguiente patrón *+*+
        public static void ImprimirAsteriscosSumas(int n)
        {
            for (int i = 0; i < n / 2; i++)
            {
                System.Console.Write("*");
                if (i < n - 1)
                    System.Console.Write("+");
            }

            // Alternativa:
        }

        // 15. Hacer una función que se le pase un entero e imprima el siguiente patrón *+-/
        public static void ImprimirPatron1(int n)
        {
            for (int i = 0; i < n; i++)
            {
                int resto = i % 4;
                switch (resto)
                {
                    case 0:
                        System.Console.Write("*");
                        break;
                    case 1:
                        System.Console.Write("+");
                        break;
                    case 2:
                        System.Console.Write("-");
                        break;
                    case 3:
                        System.Console.Write("/");
                        break;
                }
            }
        }

        // 16. Hacer una función que se le pase un entero e imprima un cuadrado
        public static void ImprimirRectangulo(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    System.Console.Write("*");
                    System.Console.WriteLine();
            }
        }

        // 17. Hacer una función que devuelva el menor de 16 enteros y tiene que ocupar 1 línea
        public static int MenordeDieciseis(int n1, int n2, int n3, int n4, int n5, int n6, int n7, int n8, int n9, int n10, int n11, int n12, int n13, int n14, int n15, int n16)
        {
            return MenordeCuatro(MenordeCuatro(n1, n2, n3, n4), MenordeCuatro(n5, n6, n7, n8), MenordeCuatro(n9, n10, n11, n12), MenordeCuatro(n13, n14, n15, n16));
        }

        // 18. Hacer una función que imprima un cuadrado de asteriscos y sumas
        public static void ImprimirCuadrado2(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    if ((r % 2) == 0)
                    System.Console.Write("*");
                    else 
                    System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        // 19.
        public static void ImprimirCuadrado3(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < n; c++)
                {
                    int flag = r + c;
                    if (flag % 2 == 0)
                    System.Console.Write("*");
                    else
                    System.Console.Write("+");
                }
                System.Console.WriteLine();
            }
        }

        // 20. Hacer una función que imprima medio triangulo
        public static void ImprimirTirangulo(int n)
        {
            for (int r = 0; r < n; r++)
            {
                for (int c = 0; c < r + 1; c++)
                    System.Console.Write("*");
                    System.Console.WriteLine();
            }
           
        }

        // 21. 
        public static void ImprimirTiranguloInvert(int n)
        {
            for (int r = 0; r < n; r++)
            {
                int espacios = n - r - 1;
                int asteriscos = r + 1;

                for (int c = 0; c < r; c++)
                {
                    System.Console.Write();
                    System.Console.Write();
                    System.Console.WriteLine();
                }
            }

        }
    }

}
