//_params = line, newLine
if (ItemChecks.IsString(line))
{
    line = line.Substring(1, line.Length - 2);

    Console.WriteLine(line);

    return;
}
else if (line.EndsWith(";") || line.EndsWith(")") || line.EndsWith(");"))
{
    if (!line.EndsWith(";")) line = $"{line};";
    Program prog = new Program();
    Console.WriteLine(prog.ExternalComplieCode(null, new string[] { line }));
}
else if (VariableCode.variableList.ContainsKey(line))
{
    Console.WriteLine(VariableCode.variableList[line]);
}
/*else
{
    try
    {
        Console.WriteLine(new DataTable().Compute(line, ""));
    }
    catch
    {

    }
}*/