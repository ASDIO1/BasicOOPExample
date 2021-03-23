using System;
using System.Collections.Generic;
using System.Text;

namespace OOPExample
{
    class PlayStationConsole
    {
        public enum PowerState
        {
            On,
            Off
        }
        // Porperties / Atributes
        public PowerState power;

        //Constructor
        public PlayStationConsole()
        {
            power = PowerState.Off;
        }

        // Methods
        public void TurnConsoleOn()
        {
            power = PowerState.On;
        }

        public void ShowConsoleState()
        {
            Console.WriteLine($"{this.GetType().Name} state: ");
        }
    }
}
