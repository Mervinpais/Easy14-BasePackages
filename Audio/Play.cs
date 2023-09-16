//_params = audioFileToPlay

try
{
    SoundPlayer soundPlayer = new SoundPlayer(audioFileToPlay.Substring(1,audioFileToPlay.Length -2));
    soundPlayer.Load();
    AudioPlayers.Add(AudioPlayers.Count+1, soundPlayer);
    soundPlayer.Play();
}
catch (Exception ex)
{
    Console.WriteLine($"Error; {ex.Message}");
}
return;