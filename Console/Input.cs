//_params = line

if (line == "")
{
    Console.Write("> ", false);
    string returnedInput = Console.ReadLine();

    if (!returnedInput.StartsWith("\"")) returnedInput = "\"" + returnedInput;
    if (!returnedInput.EndsWith("\"")) returnedInput = returnedInput + "\"";

    return returnedInput;
}
else if (ItemChecks.IsString(line))
{
    line = line.Substring(1, line.Length - 2);
    Console.WriteLine(line);
    Console.Write("> ", false);
    string returnedInput = Console.ReadLine();

    if (!returnedInput.StartsWith("\"")) returnedInput = "\"" + returnedInput;
    if (!returnedInput.EndsWith("\"")) returnedInput = returnedInput + "\"";

    return returnedInput;
}
else
{
    if (VariableCode.variableList.TryGetValue(line, out var val))
    {
        Console.WriteLine(val);
        Console.Write("> ", false);
        string returnedInput = Console.ReadLine();

        if (!returnedInput.StartsWith("\"")) returnedInput = "\"" + returnedInput;
        if (!returnedInput.EndsWith("\"")) returnedInput = returnedInput + "\"";

        return returnedInput;
    }
    else
    {
        ErrorReportor.ConsoleLineReporter.Error("Failed to get variable \'" + line + "\', make sure variable exists.");
        return "";
    }
}