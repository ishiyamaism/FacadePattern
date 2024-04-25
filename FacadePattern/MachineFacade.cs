namespace FacadePattern;

public static class MachineFacade
{
  private static int _fanStopValue;
  /// <summary>
  /// Fanを止めて後のBox内部温度
  /// </summary>
  /// <returns></returns>
  public static int BoxInternalTemperatureFanStop()
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

  public static int BoxInternalTemperature()
  {
    return new Box().GetInternalTemperature();
  }

  public static int BoxInternalTemperatureInMemory()
  {
    return _fanStopValue;
  }

  public static int BoxExternalTemperature()
  {
    return new Box().GetExternalTemperature();
  }

  public static void CameraTake()
  {
    if (BoxInternalTemperature() > 80)
    {
      throw new Exception("高温時はカメラを使用しないでください！");
    }
    new Camera().Take();
  }
  public static FanEntity FanSpin(int fanId)
  {
    return new Fan().GetSpin(fanId);
  }

  public static void FanStart(int fanId)
  {
    new Fan().Start(fanId);
  }

  public static void FanStop(int fanId)
  {
    new Fan().Stop(fanId);
  }

  public static void PowerOn()
  {
    new Power().On();
  }

  public static void PowerOff()
  {
    new Power().Off();
  }

  public static void PowerBacklightOff()
  {
    new Power().BacklightOff();
  }
}
