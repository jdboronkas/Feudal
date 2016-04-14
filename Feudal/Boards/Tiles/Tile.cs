using Feudal.Boards.Tiles.Buildings;
using Feudal.Boards.Tiles.Terrains;
using Feudal.Boards.Tiles.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles
{
    public class Tile
    {
        public Tile North { get; set; }
        public Tile East { get; set; }
        public Tile South { get; set; }
        public Tile West { get; set; }

        public Terrain Terrain { get; set; }
        public Building Building { get; set; }
        public Unit Unit { get; set; }

        public Tile()
        {
        }
    }
}
