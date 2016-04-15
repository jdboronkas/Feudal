using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards.Tiles.Units
{
    public class Pikeman : Unit
    {
        public Pikeman()
        {
            CombatValue = 3;
        }

        public override List<Tile> GetValidMoves()
        {
            throw new NotImplementedException();
        }
    }
}
