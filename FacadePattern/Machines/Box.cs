namespace FacadePattern.Machines;
internal class Box
{
    private Random _random = new Random();
    internal int GetInternalTemperature()
    {
        return _random.Next(10, 80);
    }

    internal int GetExternalTemperature()
    {
        return _random.Next(10, 80);
    }
}
