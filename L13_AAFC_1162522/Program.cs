class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bienvenido ");
        string[] nom = new string[5];
        int[] ed = new int[5];


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Edad de la persona: ");

            ed[i] = int.Parse(Console.ReadLine());

            Console.WriteLine("Nombre de la persona: ");
            nom[i] = Console.ReadLine();
        }
        Console.WriteLine("Se muestran la siguientes personas con la mayoria de edad");
        for (int i = 0; i < 5; i++)
        {
            if (ed[i] >= 18)
            {

                Console.WriteLine(nom[i]);

                Console.WriteLine("y su edad es :" + ed[i]);
            }
        }
        Console.ReadKey();
    }
}