using System.Linq.Expressions;

namespace Balkezesek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Balkezesek> balkezesekLista = new List<Balkezesek>();

            StreamReader streamReader = new StreamReader("balkezesek.csv");
            streamReader.ReadLine();
            while (!streamReader.EndOfStream)
            {
                string[] sor = streamReader.ReadLine().Split(";");
                balkezesekLista.Add(new Balkezesek(sor[0], sor[1], sor[2], int.Parse(sor[3]), int.Parse(sor[4])));
            }
            streamReader.Close();

            Console.WriteLine($"3. feladat: {balkezesekLista.Count}");
            Console.WriteLine("4. feladat:");
            foreach (Balkezesek elem in balkezesekLista)
            {
                if (elem.Utolso.Split("-")[0] == "1999" && elem.Utolso.Split("-")[1] == "10")
                {
                    Console.WriteLine($"\t{elem.Nev}, {Math.Round(elem.Magassag * 2.54, 1)} cm");
                }
            }
            Console.WriteLine("5. feladat:");
            Console.Write("Kérek egy 1990 és 1999 közötti évszámot!: ");
            string evszam = Console.ReadLine();
            do
            {
                if (!(1990 <= int.Parse(evszam) && int.Parse(evszam) <= 1999))
                {
                    Console.Write("Hibás adat, kérek egy 1990 és 1999 közötti évszámot!: ");
                    evszam = Console.ReadLine();
                }
            } while (1990 <= int.Parse(evszam) && int.Parse(evszam) <= 1999);
        }
    }
}