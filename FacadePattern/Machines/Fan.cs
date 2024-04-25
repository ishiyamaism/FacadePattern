
namespace FacadePattern.Machines;
internal class Fan
{
    private Random _random = new Random();
    internal FanEntity GetSpin(int fanId)
    {
        return new FanEntity(fanId, _random.Next(0, 3000));
    }

    internal void Start(int fanId)
    {
    }

    internal void Stop(int fanId)
    {
    }
}
