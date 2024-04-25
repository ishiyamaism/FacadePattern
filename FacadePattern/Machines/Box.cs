namespace FacadePattern.Machines;
internal class Box
{
    private Random _random = new Random();
    internal int GetInternalTemperature()
    {
        int internalTemperature = _random.Next(10, 80);
        Console.WriteLine($"本当の温度は{internalTemperature}℃");
        return internalTemperature;
    }

    internal int GetExternalTemperature()
    {
        return _random.Next(10, 80);
    }
}
