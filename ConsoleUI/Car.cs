using System;

namespace ConsoleUI;

public class Car : Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("A car drives on four wheels");
    }
    
    public bool HasTrunk { get; set; }
}