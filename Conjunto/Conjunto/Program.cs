
namespace Conjunto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students for course A? ");
            int n = int.Parse(Console.ReadLine());
            HashSet<int> a = new HashSet<int>();
            for(int i = 0; i < n; i++)
            {
                a.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course B? ");
            n = int.Parse(Console.ReadLine());
            HashSet<int> b = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                b.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("How many students for course C? ");
            n = int.Parse(Console.ReadLine());
            HashSet<int> c = new HashSet<int>();
            for (int i = 0; i < n; i++)
            {
                c.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> d = new HashSet<int>();
            d.UnionWith(a);
            d.UnionWith(b);
            d.UnionWith(c);

            Console.WriteLine("Total students: " + d.Count);
        }
    }
}









