using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builders.ComputerBuilder
{
   public  interface IComputerSystemBuilder
    {
        void AddRAM(string RAM);
        void AddDrive(string Size);
        void AddGraphics(string Size);
        void AddKeboard(string type);
        void AddMouse(string type);
        void AddMonitor(string size);
        ComputerSystem GetSystem();
    }
}
