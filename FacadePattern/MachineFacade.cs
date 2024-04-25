namespace FacadePattern;

public static class MachineFacade
{
  public static int BoxInternalTemperature()
  {
    return new Box().GetInternalTemperature();
  }

  public static int BoxExternalTemperature()
  {
    return new Box().GetExternalTemperature();
  }

  public static void CameraTake()
  {
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
