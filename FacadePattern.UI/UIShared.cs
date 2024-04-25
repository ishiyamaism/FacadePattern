namespace FacadePattern.UI;

internal static class UIShared
{
  /// <summary>
  /// Facade利用のダミーか/本番かを切り替える
  /// </summary>
  private static readonly bool isDummy = false;

  /// <summary>
  /// 利用するFacadeのUI
  /// (実装に応じて切り替える)
  /// </summary>
  static UIShared()
  {
    if (isDummy)
    {
      MachineFacade = new DummyMachineFacade();
    }
    else
    {
      MachineFacade = new MachineFacade();
    }
  }

  internal static IMachineFacade MachineFacade { get; }
}
