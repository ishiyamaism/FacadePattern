using FacadePattern.Machines;

namespace FacadePattern;

public class MachineFacade : IMachineFacade
{
  private static int _fanStopValue;

  /// <summary>
  /// Fanを止めて後のBox内部温度
  /// </summary>
  /// <returns>BoxInternalTemperature</returns>
  public int BoxInternalTemperatureFanStop()
  {
    FanStop(0);

    try
    {
      System.Threading.Thread.Sleep(5000);
      _fanStopValue = new Box().GetInternalTemperature();
      return _fanStopValue;
    }
    finally
    {
      FanStart(0);
    }
  }

  public int BoxInternalTemperature()
  {
    return new Box().GetInternalTemperature();
  }

  public int BoxInternalTemperatureInMemory()
  {
    return _fanStopValue;
  }

  public int BoxExternalTemperature()
  {
    return new Box().GetExternalTemperature();
  }

  public void CameraTake()
  {
    if (BoxInternalTemperature() > 80)
    {
      throw new Exception("高温時はカメラを使用しないでください！");
    }
    new Camera().Take();
  }
  public FanEntity FanSpin(int fanId)
  {
    return new Fan().GetSpin(fanId);
  }

  public void FanStart(int fanId)
  {
    new Fan().Start(fanId);
  }

  public void FanStop(int fanId)
  {
    new Fan().Stop(fanId);
  }

  public void PowerOn()
  {
    new Power().On();
  }

  public void PowerOff()
  {
    new Power().Off();
  }

  public void PowerBacklightOff()
  {
    new Power().BacklightOff();
  }
}
