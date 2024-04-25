using FacadePattern.Machines;

namespace FacadePattern.UI;

/// <summary>
/// Machines側の実装を待つ間、など用に
/// クライアント側に仮に持つダミーFacade
/// </summary>
internal sealed class DummyMachineFacade : IMachineFacade
{
  /// <summary>
  /// Fanを止めて後のBox内部温度
  /// </summary>
  /// <returns>BoxInternalTemperature</returns>
  public int BoxInternalTemperatureFanStop()
  {
    throw new NotImplementedException();
  }

  public int BoxInternalTemperature()
  {
    throw new NotImplementedException();
  }

  public int BoxInternalTemperatureInMemory()
  {
    throw new NotImplementedException();
  }

  public int BoxExternalTemperature()
  {
    throw new NotImplementedException();
  }

  public void CameraTake()
  {
    throw new NotImplementedException();
  }
  public FanEntity FanSpin(int fanId)
  {
    throw new NotImplementedException();
  }

  public void FanStart(int fanId)
  {
    throw new NotImplementedException();
  }

  public void FanStop(int fanId)
  {
    throw new NotImplementedException();
  }

  public void PowerOn()
  {
    throw new NotImplementedException();
  }

  public void PowerOff()
  {
    throw new NotImplementedException();
  }

  public void PowerBacklightOff()
  {
    throw new NotImplementedException();
  }

  FanEntity IMachineFacade.FanSpin(int fanId)
  {
    throw new NotImplementedException();
  }
}
