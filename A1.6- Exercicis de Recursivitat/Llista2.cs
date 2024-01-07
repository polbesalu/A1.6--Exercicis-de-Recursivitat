using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._6__Exercicis_de_Recursivitat
{
    public static class Llista2
    {
        /// <summary>
        /// menu per provar els metodes
        /// </summary>
        public static void menu()
        {
            int opcio = 0;
            do
            {
                Console.WriteLine("\n2. fibonacci");
                Console.WriteLine("3. esPrimer");
                Console.WriteLine("4. esTriangular");
                Console.WriteLine("5. esPerfecte");
                Console.WriteLine("6. capgirar");
                Console.WriteLine("7. Max");
                Console.WriteLine("8. producteEscalar");
                Console.WriteLine("9. posicio");
                Console.WriteLine("10. coincideix");
                Console.WriteLine("11. capicua");
                Console.WriteLine("12. estaOrdenat");
                Console.WriteLine("13. prefixSumaZero");
                Console.WriteLine("14. existeixSuma");
                Console.WriteLine("15. interseccioBuida");
                Console.WriteLine("0. Sortir\n");
                Console.Write("Escull una opció: ");
                opcio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opcio)
                {
                    case 2:
                        Console.WriteLine("Introdueix un numero");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(fibonacci(n));
                        break;
                    case 3:
                        Console.WriteLine("Introdueix un numero");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(esPrimer(n));
                        break;
                    case 4:
                        Console.WriteLine("Introdueix un numero");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(esTriangular(n));
                        break;
                    case 5:
                        Console.WriteLine("Introdueix un numero");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(esPerfecte(n));
                        break;
                    case 6:
                        Console.WriteLine("Introdueix un numero");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(capgirar(n));
                        break;
                    case 7:
                        Console.WriteLine("Introdueix un vector");
                        int[] v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(Max(v));
                        break;
                    case 8:
                        Console.WriteLine("Introdueix dos vectors");
                        int[] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        int[] b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                            Console.WriteLine(producteEscalar(a, b));
                        break;
                        case 9:
                        Console.WriteLine("Introdueix un vector");
                        v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine("Introdueix un numero");
                        n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(posicio(v, n));
                        break;
                        case 10:
                        Console.WriteLine("Introdueix un vector");
                        v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(coincideix(v));
                        break;
                        case 11:
                        Console.WriteLine("Introdueix un vector");
                        v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(capicua(v));
                        break;
                        case 12:
                        Console.WriteLine("Introdueix un vector");
                        v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(estaOrdenat(v));
                        break;
                        case 13:
                        Console.WriteLine("Introdueix un vector");
                        v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(prefixSumaZero(v));
                        break;
                        case 14:
                        Console.WriteLine("Introdueix un vector");
                        v = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(existeixSuma(v));
                        break;
                        case 15:
                        Console.WriteLine("Introdueix dos vectors");
                        a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        b = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
                        Console.WriteLine(interseccioBuida(a, b));
                        break;
                }
            }while (opcio != 0);
        }

        /// <summary>
        ///  Dissenyeu una funció que calculi l’n-èssim terme de la successió de Fibonacci de manera que la seva eficiència sigui lineal. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int fibonacci(int n)
        {
            if (n == 0 || n == 1)
            {
                return n;
            }
            else
            {
                return fibonacci(n - 1) + fibonacci(n - 2);
            }
        }
        /// <summary>
        ///  Un número és primer si té estrictament dos divisors. Dissenyeu una funció que ens digui si un número és primer. 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="divisor"></param>
        /// <returns></returns>
        public static bool esPrimer(int n, int divisor = 2)
        {
            if (n == 1)
            {
                return false;
            }
            else if (n == divisor)
            {
                return true;
            }
            else if (n % divisor == 0)
            {
                return false;
            }
            else
            {
                return esPrimer(n, divisor + 1);
            }
        }
        /// <summary>
        ///  Un número és triangular quan es pot expressar com la suma de naturals consecutius a partir de l’1. Ex: 6 = 1 + 2 + 3; 10 = 1 + 2 + 3 + 4. 
        ///  Fer una funció recursiva que donat un número natural, ens digui si és triangular. 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="suma"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool esTriangular(int n, int suma = 0, int i = 1)
        {
            if (n == suma)
            {
                return true;
            }
            else if (n < suma)
            {
                return false;
            }
            else
            {
                return esTriangular(n, suma + i, i + 1);
            }
        }
        /// <summary>
        /// Un número és perfecte si és igual a la suma de tots els seus divisors (sense comptar-se ell mateix, és clar). 
        /// Dissenyeu una funció que ens digui si un nombre és perfecte. 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="divisor"></param>
        /// <param name="suma"></param>
        /// <returns></returns>
        public static bool esPerfecte(int n, int divisor = 1, int suma = 0)
        {
            if (n == divisor)
            {
                return n == suma;
            }
            else if (n % divisor == 0)
            {
                return esPerfecte(n, divisor + 1, suma + divisor);
            }
            else
            {
                return esPerfecte(n, divisor + 1, suma);
            }
        }
        /// <summary>
        ///  Dissenyeu una funció que capgiri un número enter (sense fer servir strings). 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="capgirat"></param>
        /// <returns></returns>
        public static int capgirar(int n, int capgirat = 0)
        {
            if (n == 0)
            {
                return capgirat;
            }
            else
            {
                return capgirar(n / 10, capgirat * 10 + n % 10);
            }
        }
        /// <summary>
        ///  Fer una funció que retorni el valor màxim d’un vector d’enters.  
        /// </summary>
        /// <param name="v"></param>
        /// <param name="i"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static int Max(int[] v, int i = 0, int max = int.MinValue)
        {
            if (i == v.Length)
            {
                return max;
            }
            else
            {
                return Max(v, i + 1, Math.Max(max, v[i]));
            }
        }
        /// <summary>
        /// Dissenyeu un algorisme recursiu que calculi el producte escalar de dos vectors d’enters a[1:n] i b[1:n] amb n ≥ 0.  
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="i"></param>
        /// <param name="suma"></param>
        /// <returns></returns>
        public static int producteEscalar(int[] a, int[] b, int i = 0, int suma = 0)
        {
            if (i == a.Length)
            {
                return suma;
            }
            else
            {
                return producteEscalar(a, b, i + 1, suma + a[i] * b[i]);
            }
        }
        /// <summary>
        /// Dissenyeu un algorisme recursiu que donat un vector d’enters i un enter x, torni la posició on es troba x dins del vector (-1 si no hi és). 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="x"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static int posicio(int[] v, int x, int i = 0)
        {
            if (i == v.Length)
            {
                return -1;
            }
            else if (v[i] == x)
            {
                return i;
            }
            else
            {
                return posicio(v, x, i + 1);
            }
        }
        /// <summary>
        ///  Fer una funció recursiva que ens digui si algun element d’un vector coincideix amb la suma dels elements que el precedeixen.  
        /// </summary>
        /// <param name="v"></param>
        /// <param name="i"></param>
        /// <param name="suma"></param>
        /// <returns></returns>
        public static bool coincideix(int[] v, int i = 0, int suma = 0)
        {
            if (i == v.Length)
            {
                return false;
            }
            else if (v[i] == suma)
            {
                return true;
            }
            else
            {
                return coincideix(v, i + 1, suma + v[i]);
            }
        }
        /// <summary>
        /// Fer una funció recursiva que digui si un vector és cap-i-cua. Un vector és capicua si els elements equidistants dels extrems són iguals.  
        /// </summary>
        /// <param name="v"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool capicua(int[] v, int i = 0, int j = -1)
        {
            if (i == v.Length / 2)
            {
                return true;
            }
            else if (v[i] != v[j])
            {
                return false;
            }
            else
            {
                return capicua(v, i + 1, j - 1);
            }
        }
        /// <summary>
        ///  Dissenyeu un algorisme recursiu que donat un vector d’enters, decideixi si el vector està ordenat. Pot estar ordenat de manera creixent o decreixent. 
        /// </summary>
        /// <param name="v"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool estaOrdenat(int[] v, int i = 0)
        {
            if (i == v.Length - 1)
            {
                return true;
            }
            else if (v[i] > v[i + 1])
            {
                return false;
            }
            else
            {
                return estaOrdenat(v, i + 1);
            }
        }
        /// <summary>
        /// Fer una funció recursiva que donat un vector V d’enters, digui quina és la longitud del prefix més llarg que suma zero. 
        /// Si no n’hi ha cap, la funció retornarà 0. S’entén per prefix qualsevol subvector de V que comenci per V[0].  
        /// </summary>
        /// <param name="v"></param>
        /// <param name="i"></param>
        /// <param name="suma"></param>
        /// <returns></returns>
        public static int prefixSumaZero(int[] v, int i = 0, int suma = 0)
        {
            if (i == v.Length)
            {
                return 0;
            }
            else if (suma + v[i] == 0)
            {
                return i + 1;
            }
            else
            {
                return prefixSumaZero(v, i + 1, suma + v[i]);
            }
        }
        /// <summary>
        /// Dissenyeu un algorisme recursiu que donat un vector d’enters a[1:n] amb n ≥ 0, decideixi si existeix una manera de descompondre’l 
        /// en una part esquerra i una part dreta que sumin el mateix. Evidentment, aquestes parts poden ser de mides diferents.  
        /// </summary>
        /// <param name="v"></param>
        /// <param name="i"></param>
        /// <param name="suma"></param>
        /// <returns></returns>
        public static bool existeixSuma(int[] v, int i = 0, int suma = 0)
        {
            if (i == v.Length)
            {
                return suma == 0;
            }
            else
            {
                return existeixSuma(v, i + 1, suma + v[i]) || existeixSuma(v, i + 1, suma);
            }
        }
        /// <summary>
        /// Dissenyeu un algorisme recursiu que donats dos vectors d’enters ordenats creixentment, a[1:n] i b[1:m] amb n i m diferents, n ≥ 0 i m ≥ 0,
        /// que representen dos conjunts d’enters, decideixi si la seva intersecció és buida o no.  
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        public static bool interseccioBuida(int[] a, int[] b, int i = 0, int j = 0)
        {
            if (i == a.Length || j == b.Length)
            {
                return true;
            }
            else if (a[i] == b[j])
            {
                return false;
            }
            else if (a[i] < b[j])
            {
                return interseccioBuida(a, b, i + 1, j);
            }
            else
            {
                return interseccioBuida(a, b, i, j + 1);
            }
        }
    }
}
