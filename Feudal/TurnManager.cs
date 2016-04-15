using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal
{
    public class TurnManager
    {
        public List<Team> TeamTurnOrder { get; private set; }
        public Team CurrentTeamPlaying { get; private set; }
        private int TurnOrderIndex;

        public TurnManager()
        {
            TeamTurnOrder = new List<Team>();
            TurnOrderIndex = 0;
        }

        public void NextTurn()
        {
            if (TeamTurnOrder == null || TeamTurnOrder.Count <= 0)
            {
                return;
            }

            if (TurnOrderIndex > TeamTurnOrder.Count)
            {
                TurnOrderIndex = 0;
            }

            CurrentTeamPlaying = TeamTurnOrder.ElementAt(TurnOrderIndex);
            TurnOrderIndex += 1;
        }
    }
}
