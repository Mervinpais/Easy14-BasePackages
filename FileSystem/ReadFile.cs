//_params = file

try
{
    return File.ReadAllText(file);
}
catch (Exception ex) { Console.WriteLine(ex.Message); return null; }