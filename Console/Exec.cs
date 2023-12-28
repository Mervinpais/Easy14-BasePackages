using Easy14_Programming_Language;
public class MyClass
{
    public static void Beep(string line)
    {
        if (line == null) { return; }

        if (ItemChecks.IsString(line))
        {
            Program prog = new Program();
            prog.ExternalCompileCode(textArray: new string[] { line.Substring(1, line.Length - 2) });
        }
        else
        {
            //reimplement later
            /*if (VariableCode.variableList.TryGetValue(line, out _) == true)
            {
                VariableCode.variableList.TryGetValue(line, out object val);
                Program prog = new Program();
                prog.ExternalCompileCode(textArray: new string[] { val.ToString() });
            }
            else
            {
                ErrorReportor.ConsoleLineReporter.Error("Failed to get variable \'" + line + "\', make sure variable exists.");
                return;
            }*/
        }
    }
}