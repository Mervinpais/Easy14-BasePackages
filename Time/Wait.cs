//_params = line

if (!ItemChecks.IsInt(line)) { return; }

try { Thread.Sleep(Convert.ToInt32(line) * 1000); }
catch (Exception e) { ErrorReportor.ConsoleLineReporter.Error(e.Message); }