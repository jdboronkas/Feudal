using Feudal.Boards;
using Feudal.Boards.Tiles;
using Feudal.Boards.Tiles.Buildings;
using Feudal.Boards.Tiles.Units;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feudal
{
    public partial class MainForm : Form
    {
        private Board Board;
        private TurnManager TurnManager;
        private List<Team> Teams;
        private List<Player> Players;
        private bool IsGamePlaying;

        public MainForm()
        {
            InitializeComponent();

            Board = new Board();

            Teams = CreateTeams();
            Players = CreatePlayers();

            AssignTeams();

            TurnManager = new TurnManager();
            SetTurnOrder();

            SetupBoard();
            Board.SaveBoardState();

            // Kick-off the game.
            IsGamePlaying = true;
            while (IsGamePlaying == true)
            {
                TurnManager.NextTurn();
                Board.SaveBoardState();
                TakeTurn(TurnManager.CurrentTeamPlaying, ref Board);
                CheckForVictory(Board);
            }
        }

        // TODO Show Results Screen if a victory is found.
        private void CheckForVictory(Board board)
        {
            if (board == null) throw new ArgumentNullException("board cannot be null!");

            bool victoryExists = false;
            foreach (Team team in Teams)
            {
                foreach (Player player in team.Players)
                {
                    // Check for a team missing all royalty.
                    foreach (Unit unit in player.Units)
                    {
                        // TODO PICKUP
                    }

                    // Check for a team missing all castles OR is controlling all towns.
                    foreach (Building building in player.Buildings)
                    {
                        // TODO
                    }
                }
            }

            if (victoryExists == true)
            {
                IsGamePlaying = false;
            }
        }

        private void ShowResultsScreen()
        {
            // TODO Show MessageBox for now...
        }

        // TODO GUI Interaction
        private void TakeTurn(Team currentTeamPlaying, ref Board board)
        {
            if (currentTeamPlaying == null) throw new ArgumentNullException("currentTeamPlaying cannot be null!");
            if (board == null) throw new ArgumentNullException("board cannot be null!");


        }

        private void SetupBoard()
        {
            List<Tile> tiles = GetMapTerrain();

            if (tiles == null) throw new ArgumentNullException("tiles cannot be null!");
            if (Teams == null) throw new ArgumentNullException("Teams cannot be null!");
            if (Board == null) throw new ArgumentNullException("Board cannot be null!");

            foreach (Team team in Teams)
            {
                Placement(ref tiles, team);
            }

            if (tiles == null) throw new InvalidOperationException("Placement made tiles null!");

            Board.SetTiles(tiles);
        }

        // TODO Turn Order Form
        private void SetTurnOrder()
        {
            if (Teams == null) throw new ArgumentNullException("Teams can not be null!");
            if (TurnManager == null) throw new ArgumentNullException("TurnManager can not be null!");


            foreach (Team team in Teams)
            {
                TurnManager.TeamTurnOrder.Add(team);
            }
        }

        // TODO Team Assignment Form
        private void AssignTeams()
        {
            
        }

        // TODO Player Creation Form
        private List<Player> CreatePlayers()
        {
            return new List<Player>();
        }

        // TODO Team Creation Form
        private List<Team> CreateTeams()
        {
            return new List<Team>();
        }

        // TODO Terrain Editor
        private List<Tile> GetMapTerrain()
        {
            return new List<Tile>();
        }

        // TODO Team Peice Placement Form
        private void Placement(ref List<Tile> tiles, Team team)
        {
            
        }
    }
}
