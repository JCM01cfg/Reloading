using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reloading
{
    public class CartridgeStats
    {
        public string Cartridge { get; set; }
        public double AvgVelocity { get; set; }

        public double AvgES { get; set; }

        public double AvgSD { get; set; }
        public int RecipeCount { get; set; }
    }
}
