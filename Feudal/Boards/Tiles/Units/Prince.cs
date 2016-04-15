using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles.Units
{
    public class Prince : Unit
    {
        public Prince()
        {
            CombatValue = 6;
        }

        public override List<Tile> GetValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
