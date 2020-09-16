using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builders.ComputerBuilder.ConcreteBuilder
{
    public class LeptopBuilder : IComputerSystemBuilder
    {

        ComputerSystem leptop = new ComputerSystem();

        public void AddDrive(string Size)
        {
            leptop.HardDrive = Size;
        }

        public void AddGraphics(string Size)
        {
            leptop.GraphicsCard = Size;
        }

        public void AddKeboard(string type)
        {
            return;
        }

        public void AddMonitor(string size)
        {
            return;
        }

        public void AddMouse(string type)
        {
            return;
        }

        public void AddRAM(string RAM)
        {
            leptop.RAM = RAM;
        }

        public ComputerSystem GetSystem()
        {
            return leptop;
        }
    }
}
