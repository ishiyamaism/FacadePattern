using FacadePattern.Machines;

namespace FacadePattern;

public interface IMachineFacade
{
  /// <summary>
  /// Fanを止めて後のBox内部温度
  /// </summary>
  /// <returns>BoxInternalTemperature</returns>
  int BoxInternalTemperatureFanStop();

  int BoxInternalTemperature();

  int BoxInternalTemperatureInMemory();

  int BoxExternalTemperature();

  void CameraTake();

  FanEntity FanSpin(int fanId);

  void FanStart(int fanId);
  void FanStop(int fanId);
  void PowerOn();

  void PowerOff();

  void PowerBacklightOff();
}
