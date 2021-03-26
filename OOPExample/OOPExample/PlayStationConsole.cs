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
        //PROPERTIES
        private PowerState _Power;
        public string ConsoleName { get; set; }
        //CONTRSUCTOR
        public PlayStationConsole()
        {
            _Power = PowerState.Off;
            ConsoleName = "Someone";
        }
        //METHODS
        public void TurnConsoleOn()
        {
            _Power = PowerState.On;
            Console.Write($"Turning {ConsoleName}'s {this.GetType().Name} ON");
        }
        public void ShowConsoleState()
        {
            Console.WriteLine($"{ConsoleName}'s {this.GetType().Name} state: {_Power}");
        }
    }
}
