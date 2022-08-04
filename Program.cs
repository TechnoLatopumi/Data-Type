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

        Console.ReadLine();
    }
}