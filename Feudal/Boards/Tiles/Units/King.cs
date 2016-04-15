using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles.Units
{
    public class King : Unit
    {
        public King()
        {
            CombatValue = 1;
        }

        public override List<Tile> GetValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
