//_params = address
try
{
    Ping ping = new Ping();
    if (ItemChecks.DetectType(address) == "str") address = address.Substring(1, address.Length - 2);
    return ping.Send(address).Status;
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); return IPStatus.Unknown;
}