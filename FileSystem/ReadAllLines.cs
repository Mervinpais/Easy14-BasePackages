//_params = file

try
{
    return File.ReadAllLines(file);
}
catch (Exception ex) { Console.WriteLine(ex.Message); return null; }