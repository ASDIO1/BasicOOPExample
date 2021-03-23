using System;

namespace OOPExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayStationConsole somePSconsole = new PlayStationConsole();
            PS4 diegosPS4 = new PS4();

            //Turns on consoles
            somePSconsole.TurnConsoleOn();
            diegosPS4.TurnOnConsoleRemotely();

            //Shows values for each console
            somePSconsole.ShowConsoleState();
            diegosPS4.ShowConsoleState();
        }
    }
}
