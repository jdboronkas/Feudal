using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles.Units
{
    public class Knight : Unit
    {
        public Knight()
        {
            CombatValue = 6;
        }

        public override List<Tile> GetValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
