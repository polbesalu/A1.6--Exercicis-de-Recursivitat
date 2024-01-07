using A1._6__Exercicis_de_Recursivitat;

internal class Program
{
    private static void Main(string[] args)
    {
        // disenya un menu per accedir a els menus de les classes llista1 i llista2
        // el menu ha de tenir les opcions:
        // 1. llista1
        // 2. llista2
        // 3. sortir
        // si l'usuari tria una opcio incorrecte, torna a mostrar el menu
        // si l'usuari tria llista1, mostra el menu de la classe llista1
        // si l'usuari tria llista2, mostra el menu de la classe llista2
        // si l'usuari tria sortir, acaba el programa

        void menu()
        {
            Console.WriteLine("1. llista1");
            Console.WriteLine("2. llista2");
            Console.WriteLine("3. sortir");
            Console.WriteLine("Tria una opcio: ");
            int opcio = Convert.ToInt32(Console.ReadLine());
            switch (opcio)
            {
                case 1:
                    Llista1.menu();
                    break;
                case 2:
                    Llista2.menu();
                    break;
                case 3:
                    break;
                default:
                    Console.WriteLine("Opcio incorrecte");
                    menu();
                    break;
            }
        }  
        menu();
    }
}