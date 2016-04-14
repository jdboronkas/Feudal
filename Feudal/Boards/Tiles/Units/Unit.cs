using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles.Units
{
    public abstract class Unit : IDrawable
    {
        public int Value { get; set; }
        public Image Sprite { get; set; }
        public RenderingLayer Layer { get; set; }
        public bool HasActed { get; set; }
        public Tile StartOfTurnTile { get; set; }
        public Tile CurrentTile { get; set; }

        public Unit()
        {
            Layer = RenderingLayer.Units;
        }

        public abstract List<Tile> GetValidMoves();
    }
}
