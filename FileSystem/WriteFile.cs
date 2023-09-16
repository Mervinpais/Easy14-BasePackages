//_params = file, content

try
{
    File.WriteAllText(file, content);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }