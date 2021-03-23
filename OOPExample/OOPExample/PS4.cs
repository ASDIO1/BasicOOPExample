using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    class PS4 : PlayStationConsole, IRemoteControl
    {
        public void TurnOnConsoleRemotely()
        {
            Console.WriteLine("Turns on console with remote controller");
            TurnConsoleOn();
        }

    }
}
