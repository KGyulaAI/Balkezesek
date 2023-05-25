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

            Console.WriteLine($"2. feladat: {balkezesekLista.Count}");
            Console.WriteLine();
        }
    }
}