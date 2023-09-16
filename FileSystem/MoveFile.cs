//_params = filePath, newPath

try
{
    File.Move(filePath, newPath);
}
catch (Exception ex) { Console.WriteLine(ex.Message); }