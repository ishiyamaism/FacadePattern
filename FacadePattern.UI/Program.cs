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
                    Console.WriteLine(tempInMemory);

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
