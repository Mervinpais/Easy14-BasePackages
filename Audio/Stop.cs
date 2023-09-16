//_params = indexOfAudioPlayer

try
{
    AudioPlayers[indexOfAudioPlayer].Stop();
}
catch (Exception)
{
    ErrorReportor.ConsoleLineReporter.Error("Failed to stop audio");
}

return;