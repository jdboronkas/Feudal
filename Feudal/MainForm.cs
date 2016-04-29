using Feudal.Boards;
using Feudal.Boards.Tiles;
using Feudal.Boards.Tiles.Buildings;
using Feudal.Boards.Tiles.Units;
using Feudal.GameForms;
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

            Players = CreatePlayers();
            Teams = CreateTeams();

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

            ShowResultsScreen();
        }

        // TODO Form GUI Interaction for playing the game.
        private void TakeTurn(Team currentTeamPlaying, ref Board board)
        {
            if (currentTeamPlaying == null) throw new ArgumentNullException("currentTeamPlaying cannot be null!");
            if (board == null) throw new ArgumentNullException("board cannot be null!");


        }

        private void CheckForVictory(Board board)
        {
            if (board == null) throw new ArgumentNullException("board cannot be null!");

            bool victoryExists = false;
            foreach (Team team in Teams)
            {
                bool teamHasKing = false;
                bool teamHasPrince = false;
                bool teamHasDuke = false;

                bool teamHasACastle = false;

                bool teamHasAllTowns = true;

                foreach (Player player in team.Players)
                {
                    // Check for a team missing all royalty.
                    foreach (Unit unit in player.Units)
                    {
                        if (unit is King)
                        {
                            teamHasKing = true;
                        }
                        else if (unit is Prince)
                        {
                            teamHasPrince = true;
                        }
                        else if (unit is Duke)
                        {
                            teamHasDuke = true;
                        }
                    }

                    // Check for a team missing all castles.
                    foreach (Building building in player.Buildings)
                    {
                        if (building is Castle)
                        {
                            teamHasACastle = true;
                            break;
                        }
                    }

                    // Check for a team controlling all towns.
                    foreach (Tile tile in board.Tiles)
                    {
                        if (tile.Building == null)
                        {
                            continue;
                        }

                        if ((tile.Building is Town) == false)
                        {
                            continue;
                        }

                        if (player.Buildings.Contains(tile.Building) == false)
                        {
                            teamHasAllTowns = false;
                        }
                    }
                }

                if (teamHasKing == false && teamHasPrince == false && teamHasDuke == false)
                {
                    victoryExists = true;
                }

                if (teamHasACastle == false)
                {
                    victoryExists = true;
                }

                if (teamHasAllTowns == true)
                {
                    victoryExists = true;
                }
            }

            if (victoryExists == true)
            {
                IsGamePlaying = false;
            }
        }

        // TODO Results Screen / Stat Tracking
        private void ShowResultsScreen()
        {
            MessageBox.Show("Game Over!");
        }



        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        // ~~~~~~~ GAME SETUP FUNCTIONS ~~~~~~~
        // ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        
        private List<Player> CreatePlayers()
        {
            CreatePlayersForm cp = new CreatePlayersForm();
            cp.ShowDialog();

            List<Player> players = new List<Player>();
            foreach (string playerName in cp.PlayerNames)
            {
                players.Add(new Player(playerName));
            }

            return players;
        }

        // TODO Team Creation Form
        private List<Team> CreateTeams()
        {
            // Players (is class level variable..)

            return new List<Team>();
        }

        // TODO Team Assignment Form
        private void AssignTeams()
        {

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

        // TODO Terrain Editor
        private List<Tile> GetMapTerrain()
        {
            return new List<Tile>();
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
                if (tiles == null) throw new InvalidOperationException("Placement made tiles null!");
            }

            Board.SetTiles(tiles);
        }

        // TODO Team Peice Placement Form
        private void Placement(ref List<Tile> tiles, Team team)
        {
            
        }
    }
}
