using BuilderDesignPattern.Builders.ComputerBuilder;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Threading.Tasks;

namespace BuilderDesignPattern.Builders.Director
{
    public class ComputerConfigarationBuilder
    {
        public void BuildSystem(IComputerSystemBuilder systemBuilder, IFormCollection collection)
        {
            systemBuilder.AddDrive(collection["HardDrive"]);
            systemBuilder.AddGraphics(collection["GraphicsCard"]);
            systemBuilder.AddKeboard(collection["Keyborad"]);
            systemBuilder.AddMonitor(collection["Monitor"]);
            systemBuilder.AddMouse(collection["Mouse"]);
            systemBuilder.AddRAM(collection["RAM"]);
        }

       
    }
}
