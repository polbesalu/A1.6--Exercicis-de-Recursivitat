using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A1._6__Exercicis_de_Recursivitat
{
    public static class Llista1
    {
        /// <summary>
        /// menu per provar els metodes
        /// </summary>
        public static void menu()
        {
            int opcio = 0;
            do
            {
                Console.WriteLine("\n1. Donat un nombre n, escriu una funció recursiva que calculi la suma dels n primers nombres naturals.");
                Console.WriteLine("3. Fer una funció que calculi el producte de dos números naturals utilitzant sumes.");
                Console.WriteLine("4. Fer una funció que calculi la potencia d’un número elevat a un altre.");
                Console.WriteLine("5. Fer una funció que faci la divisió entera entre dos números.");
                Console.WriteLine("6. Fer una funció que faci el mòdul entre dos números.");
                Console.WriteLine("7. Fer una funció que calculi el Màxim Comú Divisor de dos naturals.");
                Console.WriteLine("8. Fer una funció que calculi l’enèsim número de la sèrie de Fibonacci.");
                Console.WriteLine("9. Fer una funció que retorni un enter que sigui la interpretació en base b d’un altre enter n entrat com a argument a la funció.");
                Console.WriteLine("10. Comptar les xifres d'un nombre de forma recursiva.");
                Console.WriteLine("11. Fer una funció que ens digui si un nombre está en base b.");
                Console.WriteLine("0. Sortir \n");
                Console.Write("Escull una opció: ");
                opcio = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opcio)
                {
                    case 1:
                        Console.Write("Introdueix un nombre: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma dels n primers nombres naturals és: " + sumaNaturals(n));
                        break;
                    case 3:
                        Console.Write("Introdueix un nombre: ");
                        int a = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix un altre nombre: ");
                        int b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El producte de " + a + " i " + b + " és: " + producte(a, b));
                        break;
                    case 4:
                        Console.Write("Introdueix un nombre: ");
                        int a2 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix un altre nombre: ");
                        int b2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultat de " + a2 + " elevat a " + b2 + " és: " + potencia(a2, b2));
                        break;
                    case 5:
                        Console.Write("Introdueix un nombre: ");
                        int a3 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix un altre nombre: ");
                        int b3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El resultat de la divisió entre " + a3 + " i " + b3 + " és: " + divisio(a3, b3));
                        break;
                    case 6:
                        Console.Write("Introdueix un nombre: ");
                        int a4 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix un altre nombre: ");
                        int b4 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("El resultat del mòdul entre " + a4 + " i " + b4 + " és: " + modul(a4, b4));
                        break;
                    case 7:
                        Console.Write("Introdueix un nombre: ");
                        int a5 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix un altre nombre: ");
                        int b5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El Màxim Comú Divisor entre " + a5 + " i " + b5 + " és: " + mcd(a5, b5));
                        break;
                    case 8:
                        Console.Write("Introdueix un nombre: ");
                        int n3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El " + n3 + " nombre de la sèrie de Fibonacci és: " + fibonacci(n3));
                        break;
                    case 9:
                        Console.Write("Introdueix un nombre: ");
                        int n4 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix una base: ");
                        int b6 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El nombre " + n4 + " en base " + b6 + " és: " + baseN(n4, b6));
                        break;
                    case 10:
                        Console.Write("Introdueix un nombre: ");
                        int n5 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El nombre " + n5 + " té " + comptarXifres(n5) + " xifres.");
                        break;
                    case 11:
                        Console.Write("Introdueix un nombre: ");
                        int n6 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Introdueix una base: ");
                        int b7 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("El nombre " + n6 + " en base " + b7 + " és: " + esBaseN(n6, b7));
                        break;
                    default:
                        Console.WriteLine("Opció incorrecta");
                        break;
                }
            } while (opcio != 0);
        }

        /// <summary>
        /// 1. Donat un nombre n, escriu una funció recursiva que calculi el factorial de n.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int sumaNaturals(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else
            {
                return n + sumaNaturals(n - 1);
            }
        }
        /// <summary>
        /// Fer una funció que calculi el producte de dos números naturals utilitzant sumes.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Retorna el producte de dos números naturals</returns>
        public static int producte(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            else
            {
                return a + producte(a, b - 1);
            }
        }
        /// <summary>
        /// Fer una funció que calculi la potencia d’un número elevat a un altre
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int potencia(int a, int b)
        {
            if (b == 0)
            {
                return 1;
            }
            else
            {
                return a * potencia(a, b - 1);
            }
        }
        /// <summary>
        /// Fer una funció que faci la divisió entera entre dos números
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int divisio(int a, int b)
        {
            if (a < b)
            {
                return 0;
            }
            else
            {
                return 1 + divisio(a - b, b);
            }
        }
        /// <summary>
        ///  Fer una funció que faci el mòdul entre dos números
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int modul(int a, int b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return modul(a - b, b);
            }
        }
        /// <summary>
        /// Fer una funció que calculi el Màxim Comú Divisor de dos naturals
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int mcd(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return mcd(b, modul(a, b));
            }
        }

        /// <summary>
        ///  Fer una funció que calculi l’enèsim número de la sèrie de Fibonacci.  
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
        ///  Fer una funció que retorni un enter que sigui la interpretació en base b d’un altre enter n entrat com a argument a la funció. 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int baseN(int n, int b)
        {
            if (n < b)
            {
                return n;
            }
            else
            {
                return baseN(n / b, b) * 10 + n % b;
            }
        }
        /// <summary>
        ///  Comptar les xifres d'un nombre de forma recursiva. 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int comptarXifres(int n)
        {
            if (n < 10)
            {
                return 1;
            }
            else
            {
                return 1 + comptarXifres(n / 10);
            }
        }
        /// <summary>
        ///  Fer una funció que ens digui si un nombre está en base b. 
        /// </summary>
        /// <param name="n"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static bool esBaseN(int n, int b)
        {
            if (n < b)
            {
                return true;
            }
            else
            {
                return esBaseN(n / b, b);
            }
        }
    }
}
