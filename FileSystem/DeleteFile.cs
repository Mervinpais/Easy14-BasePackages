//_params = file

try
{
    File.Delete(file);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }