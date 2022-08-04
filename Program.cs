internal class Program
{
    private static void Main(string[] args)
    {
        //string
        string phrase ="Giraffe\"Academy\"";

        Console.WriteLine("===Basic String Method===");
        Console.WriteLine(phrase);
        Console.WriteLine(phrase.Contains("Academy"));
        Console.WriteLine(phrase.Length);
        Console.WriteLine(phrase[3]);
        Console.WriteLine(phrase.IndexOf("Academy"));
        Console.WriteLine(phrase.IndexOf("f"));
        Console.WriteLine(phrase.IndexOf("z"));
        Console.WriteLine(phrase.Substring(8));
        Console.WriteLine(phrase.Substring(8, 3));

        //Number
        Console.WriteLine("===Basic Number Method===");
        Console.WriteLine(-5.783);
        Console.WriteLine(5+8);
        Console.WriteLine(5*8);
        Console.WriteLine(5%2);
        Console.WriteLine(4+2*3);
        Console.WriteLine((4+2)*3);
        Console.WriteLine(5.0 + 8.1);
        Console.WriteLine(5 + 8.1);
        Console.WriteLine(5/2);
        Console.WriteLine(5/2.0);

        int num = 6;
        num++;
        Console.WriteLine(num);
        num--;
        Console.WriteLine(num);
        Console.WriteLine(Math.Abs(-40));
        Console.WriteLine(Math.Pow(3, 2));
        Console.WriteLine(Math.Pow(3.8, 2));
        Console.WriteLine(Math.Sqrt(36));
        Console.WriteLine(Math.Max(4, 90));
        Console.WriteLine(Math.Min(4, 90));
        Console.WriteLine(Math.Round(4.3));
        Console.WriteLine(Math.Round(4.6));


        Console.ReadLine();
    }
}