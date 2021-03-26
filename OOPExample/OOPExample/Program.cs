using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayStationConsole somePSconsole = new PS4();
            PS4 diegosPS4 = new PS4() {ConsoleName = "Diego" };

            //Shows values for each console
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Consoles Before Turning ON:");
            diegosPS4.ShowConsoleState();
            somePSconsole.ShowConsoleState();
            Console.ForegroundColor = ConsoleColor.White;

            //Turns on consoles
            diegosPS4.TurnOnConsoleRemotely();
            somePSconsole.TurnConsoleOn();

            //Shows values for each console
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nConsoles After Turning ON:");
            diegosPS4.ShowConsoleState();
            somePSconsole.ShowConsoleState();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
