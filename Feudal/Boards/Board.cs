using Feudal.Boards.Tiles;
using Feudal.Boards.Tiles.Buildings;
using Feudal.Boards.Tiles.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feudal.Boards
{
    public class Board
    {
        public List<Tile> Tiles { get; private set; }
        private Stack<Board> BoardStates;

        public Board()
        {
            Tiles = new List<Tile>();
            BoardStates = new Stack<Board>();
        }

        public void SetTiles(List<Tile> tiles)
        {
            if (tiles == null)
            {
                throw new ArgumentNullException("tiles cannot be set to null!");
            }

            Tiles = tiles;
        }

        public void SaveBoardState()
        {
            BoardStates.Push(this);
        }

        public void GetLastSavedBoardState()
        {
            if (BoardStates.Count <= 0)
            {
                return;
            }

            BoardStates.Pop();

            Board lastState = BoardStates.Peek();

            if (lastState == null)
            {
                return;
            }

            Tiles = lastState.Tiles;

            SaveBoardState();
        }
    }
}
