//_params = file

try
{
    File.WriteAllText(file, "");
}
catch (Exception ex) { Console.WriteLine(ex.Message); }