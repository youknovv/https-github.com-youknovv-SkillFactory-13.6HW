using System.Diagnostics;
using System.Text;
class Program
{
    public static List<string> list = new List<string>();

    static void Main(string[] args)
    {
        Stopwatch stopWatch = new Stopwatch();
        stopWatch.Start();
        Console.OutputEncoding = Encoding.UTF8;
        String line;
        try
        {
            StreamReader sr = new StreamReader("C:\\Text1.txt");
            line = sr.ReadLine();
            while (line != null)
            {
                list.Add(line);
                line = sr.ReadLine();
            }
            sr.Close();
            Console.ReadLine();
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception: " + e.Message);
        }
        stopWatch.Stop();
        Console.WriteLine(stopWatch.Elapsed);
    }
}