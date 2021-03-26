# BasicOOPExample
Simple OOP example for "Software Architecture" signature at UCB college.

This program was made to practice and showcase the core concepts of OOP (object oriented programming).
These main concepts are:
* Abstraction
* Encapsulation
* Inheritance
* Polimorfism

## Explanation
Check the code and run just the "Program.cs" file that is inside the OOPExample/OOPExample folder.

This OOP program is about Play Station Consoles.

#### Abstraction
This program has:
* PlayStationConsole.  The SuperClass.
Playstation consoles have a name and power state (ON / OFF) properties.
Playstation consoles can be turned on.
(The "ShowConsoleState" is just made for the example sake)

* PS4.  PlayStationConsole SubClass.
PS4 has all the properties of a PlayStationConsole
PS4 implements the IRemoteControl interface
PS4 implements this interface just to make the console turn on remotely.

* IRemoteControl.  Interface that is implemented by any PlayStationConsole that wants to have remote controller actions.
Is an interface that any Console could implement and give its own logic to the interface methods.

#### Encaptulation
Encaptulation in this example is used with the "Power" property, because it may not be a good thing to make a gaming console power state public to anything or anyone if they do not posses a PS console.

In order to turn on a PS console the object has to be instantiated and the user has to turn it on with a "turnOn" method.

#### Inheritance
A "PlayStationConsole" has the subclass named "PS4" which inherits the characteristics of a "PlayStationConsole".
It is also posible to add new subclasess like "PS3", "PSP", etc.

#### Polimorfism
As shown in the program, we can instantiate a "PS4" console as a "PS4" or as a "PlayStationConsole".
By doing that and turning each console on, each console has the same Type (PS4) despite each console being instantiated differently.

#### Extras
I have used some extra things in this program. For example: Reflection, Interfaces, String interpolation, etc.