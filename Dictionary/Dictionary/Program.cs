
namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> votos = new Dictionary<string, int>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        var linha = sr.ReadLine().Split(',');

                        if (votos.ContainsKey(linha[0]))
                        {
                            votos[linha[0]] += int.Parse(linha[1]);
                        }
                        else
                        {
                            votos[linha[0]] = int.Parse(linha[1]);
                        }
                    }
                    
                    foreach(var item in votos)
                    {
                        Console.WriteLine($"{item.Key}: {item.Value}");
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERRO: " + ex.Message);
            }



        }
    }
}











