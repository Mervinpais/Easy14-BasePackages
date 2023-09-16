//_params = fileName, newName

public static void Interperate(string fileName, string newName)
{
    try
    {
        File.Move(fileName, newName);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
}