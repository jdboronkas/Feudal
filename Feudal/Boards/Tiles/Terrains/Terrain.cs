using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles.Terrains
{
    public abstract class Terrain : IDrawable
    {
        public Image Sprite { get; set; }
        public RenderingLayer Layer { get; set; }

        public Terrain()
        {
            Layer = RenderingLayer.Terrains;
        }
    }
}
