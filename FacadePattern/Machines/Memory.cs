namespace FacadePattern.Machines;

internal static class Memory
{
  private static int _stopFanValue;
  public static int StopFanValue
  {
    get { return _stopFanValue * 2; } // 大人の事情で温度は２倍にして返す
    set { _stopFanValue = value; }
  }
}
