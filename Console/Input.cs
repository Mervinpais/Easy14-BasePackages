public class MyClass
{
    public static string ExecuteLine(string line)
    {
        if (line == "")
        {
            Console.Write("> ", false);
            string returnedInput = Console.ReadLine();

            if (!returnedInput.StartsWith("\"")) returnedInput = "\"" + returnedInput;
            if (!returnedInput.EndsWith("\"")) returnedInput = returnedInput + "\"";

            return returnedInput;
        }
        else if (line.StartsWith("\"") && line.EndsWith("\""))
        {
            line = line.Substring(1, line.Length - 2);
            if (line == "\\x")
            { 
                return "";
            }

            Console.WriteLine(line);
            Console.Write("> ", false);
            string returnedInput = Console.ReadLine();

            if (!returnedInput.StartsWith("\"")) returnedInput = "\"" + returnedInput;
            if (!returnedInput.EndsWith("\"")) returnedInput = returnedInput + "\"";

            return returnedInput;
        }
        else
        {
            var val = VariableCode.variables.FirstOrDefault(v => v.Name == line);

            if (val != null)
            {
                Console.WriteLine(val.Contents);
                Console.Write("> ", false);
                string returnedInput = Console.ReadLine();

                if (!returnedInput.StartsWith("\"")) returnedInput = "\"" + returnedInput;
                if (!returnedInput.EndsWith("\"")) returnedInput = returnedInput + "\"";

                return returnedInput;
            }
            else
            {
                ErrorReportor.ReportError("", "Failed to get variable \'" + line + "\', make sure variable exists.");
                return "";
            }
        }
    }
}