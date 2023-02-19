using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public bool HasSideCart { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is driving");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle can't drive it self");
        }
    }
}
/* 
            * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
            * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
            * Provide the implementations for the abstract methods
            * Only in the Motorcycle class will you override the virtual drive method
           */