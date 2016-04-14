using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal
{
    public class Team
    {
        public string Name { get; private set; }
        public List<Player> Players { get; private set; }

        public Team(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException("Player name can not be null!");
            }

            Name = name;
            Players = new List<Player>();
        }
    }
}
