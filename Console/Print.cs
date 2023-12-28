public class MyClass
{
    public static void PrintLine(string line)
    {
        if (line.StartsWith("\"") && line.EndsWith("\""))
        {
            line = line.Substring(1, line.Length - 2);
            Console.WriteLine(line);
        }
        else
        {
            Console.WriteLine("ERROR:> Unknown Print Parameter");
        }
    }
}