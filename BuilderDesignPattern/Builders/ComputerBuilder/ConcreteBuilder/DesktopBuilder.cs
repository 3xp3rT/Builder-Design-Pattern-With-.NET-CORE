using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builders.ComputerBuilder.ConcreteBuilder
{
    public class DesktopBuilder : IComputerSystemBuilder
    {
        ComputerSystem desktop = new ComputerSystem();
        public void AddDrive(string Size)
        {
            desktop.HardDrive = Size;
        }

        public void AddGraphics(string Size)
        {
            desktop.GraphicsCard = Size;
        }

        public void AddKeboard(string type)
        {
            desktop.Keyborad = type;
        }

        public void AddMonitor(string size)
        {
            desktop.Monitor = size;
        }

        public void AddMouse(string type)
        {
            desktop.Mouse = type;
        }

        public void AddRAM(string RAM)
        {
            desktop.RAM = RAM;
        }

        public ComputerSystem GetSystem()
        {
            return desktop;
        }
    }
}
