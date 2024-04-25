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

                    // たくさんの機械類を制御するようなクラス群があった場合、
                    // 何をどう使えばいいのか、クライアント側が考えなければならないのはダメな実装。
                    var fan = new Fan();
                    FanEntity entity = fan.GetSpin(4);
                    Console.WriteLine(entity.FanId.ToString());

                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Press: →");
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
