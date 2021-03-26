using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    class PS4 : PlayStationConsole, IRemoteControl
    {
        public void TurnOnConsoleRemotely()
        {
            TurnConsoleOn();
            Console.WriteLine(" With a remote controller");
        }

    }
}
