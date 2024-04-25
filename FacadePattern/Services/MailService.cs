namespace FacadePattern.Services;

/// <summary>
/// メール処理を束ねるFacade的サービスクラス
/// </summary>
public static class MailService
{
  /// <summary>
  /// メール送信処理
  /// (送信したら必ず履歴保存する、など)
  /// </summary>
  public static void Send()
  // public static void Send(IMailSender sender, IMailHistroryRepository mailHistory, MailEntity mailEntity)
  {
    // 送信するなど
    // sender.Send(mailEntity);
    // 必ず保存するなど
    // mailHistory.Save(mailEntity);
  }
}
