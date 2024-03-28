using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        string text = File.ReadAllText("Text1.txt");

        string[] words = text.Split(' ', ',', '.', '!', '?', ';', ':', '"', '(', ')', '[', ']', '{', '}', '\n', '\r', '\t');

        Dictionary<string, int> wordFrequencies = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFrequencies.ContainsKey(word))
            {
                wordFrequencies[word]++;
            }
            else
            {
                wordFrequencies[word] = 1;
            }
        }

        var sortedWordFrequencies = wordFrequencies.OrderByDescending(x => x.Value);

        Console.WriteLine("10 Самых используемых слов:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{i + 1}. {sortedWordFrequencies.ElementAt(i).Key} - {sortedWordFrequencies.ElementAt(i).Value}");
        }
    }
}
