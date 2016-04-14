using Feudal.Boards.Tiles.Buildings;
using Feudal.Boards.Tiles.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal
{
    public class Player
    {
        public string Name { get; private set; }
        public List<Unit> Units { get; private set; }
        public List<Building> Buildings { get; private set; }
        public List<Player> Allies { get; private set; }

        public Player(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Player name can not be null!");
            }

            Name = name;

            Units = new List<Unit>();
            Buildings = new List<Building>();
            Allies = new List<Player>();
        }
    }
}
