//_params = dir

try
{
    Directory.Delete(dir, true);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }