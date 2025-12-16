using System;

namespace ConsoleUI;

public class Motorcycle : Vehicle
{
    public override void DriveAbstract()
    {
        Console.WriteLine("A motorcycle drives on two wheels");
    }
    
    public bool HasSideCart {get; set;}

    public override void DriveVirtual()
    {
        Console.WriteLine("Motorcycle is driving virtual");
    }
}