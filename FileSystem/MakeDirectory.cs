//_params = dir

try
{
    Directory.CreateDirectory(dir);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }