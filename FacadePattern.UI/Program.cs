using FacadePattern.Services;

namespace FacadePattern.UI;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to say hello, and the other Keys for Input Trigger. Esc to exit.");
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);  // trueでキーのエコーをオフにする
            if (keyInfo.Key == ConsoleKey.Escape)
            {
                Console.WriteLine("bye.");
                break;
            }
            // Escキーでループを抜けてプログラムを終了

            switch (keyInfo.Key)
            {
                case ConsoleKey.Enter:
                    Console.WriteLine("Hello, World!");
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("Press: A");

                    UIShared.MachineFacade.CameraTake();
                    Console.WriteLine("Done: Camera().Take()");

                    int tempAfterFanStop = UIShared.MachineFacade.BoxInternalTemperatureFanStop();
                    Console.WriteLine($"Done: BoxInternalTemperatureFanStop(): FanStop後: {tempAfterFanStop}℃");
                    break;

                case ConsoleKey.B:
                    Console.WriteLine("Press: B");

                    int tempInMemory = UIShared.MachineFacade.BoxInternalTemperatureInMemory();
                    Console.WriteLine($"なんと{tempInMemory}℃です！");

                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Press: →");

                    // メール送信処理
                    MailService.Send();
                    // クライアント側はこれを呼ぶのみ(履歴保存は実装側で保証されている)
                    Console.WriteLine("Mail送信完了(保存されますた)");

                    break;
                case ConsoleKey.D0:
                    Console.WriteLine("Press: 0");
                    break;
                case ConsoleKey.D1:
                    Console.WriteLine("Press: 1");
                    break;

                default:
                    break;
            }
        }
    }
}
