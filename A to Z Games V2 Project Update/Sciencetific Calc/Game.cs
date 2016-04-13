using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciencetific_Calc
{
    public class Game
    {
        private List<PieceTracker> pieceList = new List<PieceTracker>();
        private Player1 currentPlayer;
        private bool check = false;
        private Player1 playerInCheck = Player1.Default;
        private bool checkmate = false;

        public List<PieceTracker> PieceList
        {
            get
            {
                return pieceList;
            }
            set
            {
                pieceList = value;
            }
        }

        public Player1 CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
            set
            {
                currentPlayer = value;
            }
        }

        public bool Check
        {
            get
            {
                return check;
            }
            set
            {
                check = value;
            }
        }

        public Player1 PlayerInCheck
        {
            get
            {
                return playerInCheck;
            }
            set
            {
                playerInCheck = value;
            }
        }

        public bool Checkmate
        {
            get
            {
                return checkmate;
            }
            set
            {
                checkmate = value;
            }
        }

        public Game()
        {
            this.addPiecesToGameList();
            this.currentPlayer = Player1.Black;
            this.check = false;
        }

        private void addPiecesToGameList()
        {
            #region whitePieces

            for (int i = 0; i <= 7; i++)
            {
                this.pieceList.Add(new PieceTracker()
                {
                    Piece = new Pawn() { Name = "White Pawn", ImageString = @"PieceImages/P1Pawn.png" },
                    Coordinate = new Coordinate() { XCoordinate = i, YCoordinate = 1 },
                    Player = Player1.White
                });
            }

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Rook() { Name = "White Rook", ImageString = @"PieceImages/P1Rook.png" },
                Coordinate = new Coordinate() { XCoordinate = 0, YCoordinate = 0 },
                Player = Player1.White
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Bishop() { Name = "White Bishop", ImageString = @"PieceImages/P1Bishop.png" },
                Coordinate = new Coordinate() { XCoordinate = 1, YCoordinate = 0 },
                Player = Player1.White
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Knight() { Name = "White Knight", ImageString = @"PieceImages/P1Knight.png" },
                Coordinate = new Coordinate() { XCoordinate = 2, YCoordinate = 0 },
                Player = Player1.White
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Queen() { Name = "White Queen", ImageString = @"PieceImages/P1Queen.png" },
                Coordinate = new Coordinate() { XCoordinate = 3, YCoordinate = 0 },
                Player = Player1.White
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new King() { Name = "White King", ImageString = @"PieceImages/P1King.png" },
                Coordinate = new Coordinate() { XCoordinate = 4, YCoordinate = 0 },
                Player = Player1.White
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Knight() { Name = "White Knight", ImageString = @"PieceImages/P1Knight.png" },
                Coordinate = new Coordinate() { XCoordinate = 5, YCoordinate = 0 },
                Player = Player1.White
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Bishop() { Name = "White Bishop", ImageString = @"PieceImages/P1Bishop.png" },
                Coordinate = new Coordinate() { XCoordinate = 6, YCoordinate = 0 },
                Player = Player1.White
            });


            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Rook() { Name = "White Rook", ImageString = @"PieceImages/P1Rook.png" },
                Coordinate = new Coordinate() { XCoordinate = 7, YCoordinate = 0 },
                Player = Player1.White
            });

            #endregion

            #region blackPieces

            for (int i = 0; i <= 7; i++)
            {
                this.pieceList.Add(new PieceTracker()
                {
                    Piece = new Pawn() { Name = "Black Pawn", ImageString = @"PieceImages/P2Pawn.png" },
                    Coordinate = new Coordinate() { XCoordinate = i, YCoordinate = 6 },
                    Player = Player1.Black
                });
            }

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Rook() { Name = "Black Rook", ImageString = @"PieceImages/P2Rook.png" },
                Coordinate = new Coordinate() { XCoordinate = 0, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Bishop() { Name = "Black Bishop", ImageString = @"PieceImages/P2Bishop.png" },
                Coordinate = new Coordinate() { XCoordinate = 1, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Knight() { Name = "Black Knight", ImageString = @"PieceImages/P2Knight.png" },
                Coordinate = new Coordinate() { XCoordinate = 2, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Queen() { Name = "Black Queen", ImageString = @"PieceImages/P2Queen.png" },
                Coordinate = new Coordinate() { XCoordinate = 3, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new King() { Name = "Black King", ImageString = @"PieceImages/P2King.png" },
                Coordinate = new Coordinate() { XCoordinate = 4, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Knight() { Name = "Black Knight", ImageString = @"PieceImages/P2Knight.png" },
                Coordinate = new Coordinate() { XCoordinate = 5, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Bishop() { Name = "Black Bishop", ImageString = @"PieceImages/P2Bishop.png" },
                Coordinate = new Coordinate() { XCoordinate = 6, YCoordinate = 7 },
                Player = Player1.Black
            });

            this.pieceList.Add(new PieceTracker()
            {
                Piece = new Rook() { Name = "Black Rook", ImageString = @"PieceImages/P2Rook.png" },
                Coordinate = new Coordinate() { XCoordinate = 7, YCoordinate = 7 },
                Player = Player1.Black
            });

            #endregion

        }

        public void PlayGame()
        {
            if (this.currentPlayer == Player1.White)
            {
                this.currentPlayer = Player1.Black;
            }

            else
            {
                this.currentPlayer = Player1.White;
            }

        }

        public void PiecePromotion(int endYCoordinate, string queenPieceName, string queenImageString, string knightPieceName, string knightImageString,
            System.Windows.Forms.PictureBox pictureBox2, Coordinate newCoordinate)
        {
            List<PieceTracker> pawnPromotionCheck = (from piece in this.PieceList
                                                     where piece.Piece.Name.Contains("Pawn")
                                                     && piece.Coordinate.YCoordinate == endYCoordinate
                                                     select piece).ToList();

            if (pawnPromotionCheck.Count > 0)
            {
                System.Windows.Forms.DialogResult pieceSelection = System.Windows.Forms.MessageBox.Show
                    ("Would you like a Knight or a Queen? Press 'Yes' for a Queen, and 'No' for a Knight",
                     "PIECE PROMOTION!", System.Windows.Forms.MessageBoxButtons.YesNo);

                Piece promotedPiece;

                int indexOfCurrentPawn = this.PieceList.FindIndex(piece =>
                    piece.Coordinate.XCoordinate == newCoordinate.XCoordinate
                    && piece.Coordinate.YCoordinate == newCoordinate.YCoordinate);

                if (pieceSelection == System.Windows.Forms.DialogResult.Yes)
                {
                    promotedPiece = new Queen();
                    this.PieceList[indexOfCurrentPawn].Piece = promotedPiece;
                    this.PieceList[indexOfCurrentPawn].Piece.Name = queenPieceName;
                    this.PieceList[indexOfCurrentPawn].Piece.ImageString = queenImageString;
                    pictureBox2.ImageLocation = queenImageString;
                    pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                }

                else
                {
                    promotedPiece = new Knight();
                    this.PieceList[indexOfCurrentPawn].Piece = promotedPiece;
                    this.PieceList[indexOfCurrentPawn].Piece.Name = knightPieceName;
                    this.PieceList[indexOfCurrentPawn].Piece.ImageString = knightImageString;
                    pictureBox2.ImageLocation = knightImageString;
                    pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                }

            }





        }

        public void CheckCheckOnThisKingWithOppositePlayerPieces()
        {
            List<PieceTracker> kingPiece = (from piece in this.PieceList
                                            where piece.Piece.Name.Contains("King")
                                            & piece.Player.Equals(this.currentPlayer)
                                            select piece).ToList();

            List<PieceTracker> oppositePlayerPieces = (from piece in this.PieceList
                                                       where !piece.Player.Equals(this.currentPlayer)
                                                       && !piece.Piece.Name.Contains("Pawn")
                                                       select piece).ToList();

            foreach (PieceTracker piecetracker in oppositePlayerPieces)
            {
                if (piecetracker.Piece.Move(piecetracker.Coordinate, kingPiece[0].Coordinate))
                {
                    this.check = true;
                    break;
                }

                else
                {
                    this.check = false;
                }
            }
        }

        public void CheckCheckMate()
        {
            if (!this.check)
            {
                return;
            }

            else
            {
                List<CheckmateState> checkmateStateList = new List<CheckmateState>();

                List<PieceTracker> playerPieces = (from piece in this.PieceList
                                                   where piece.Player.Equals(this.currentPlayer)
                                                   && !piece.Piece.Name.Contains("Pawn")
                                                   select piece).ToList();

                List<Coordinate> fullBoard = new List<Coordinate>();

                for (int j = 0; j < 8; j++)
                {


                    for (int i = 0; i < 8; i++)
                    {
                        fullBoard.Add(new Coordinate() { XCoordinate = i, YCoordinate = j });
                    }

                }


                foreach (PieceTracker piecetracker in playerPieces)
                {
                    foreach (Coordinate coordinate in fullBoard)
                    {
                        if (!piecetracker.Piece.Move(piecetracker.Coordinate, coordinate))
                        {
                            continue;
                        }

                        else
                        {
                            int pieceIndex = this.PieceList.FindIndex(piece =>
                               piece.Coordinate.XCoordinate == piecetracker.Coordinate.XCoordinate
                               && piece.Coordinate.YCoordinate == piecetracker.Coordinate.YCoordinate);

                            Coordinate oldCoordinate = piecetracker.Coordinate;
                            this.PieceList[pieceIndex].Coordinate = coordinate;

                            CheckCheckOnThisKingWithOppositePlayerPieces();

                            if (!this.Check)
                            {
                                checkmateStateList.Add(CheckmateState.MoveAvailable);

                                this.PieceList[pieceIndex].Coordinate = oldCoordinate;
                                break;
                            }

                            else
                            {
                                checkmateStateList.Add(CheckmateState.NoMoveAvailable);

                                this.PieceList[pieceIndex].Coordinate = oldCoordinate;
                            }
                        }
                    }
                }

                List<CheckmateState> checkIfMovesAvailable = (from cs in checkmateStateList
                                                              where cs.Equals(CheckmateState.MoveAvailable)
                                                              select cs).ToList();

                if (checkIfMovesAvailable.Count >= 1)
                {
                    return;
                }

                else
                {
                    this.checkmate = true;
                }

            }
        }

    }

    public enum Player1
    {
        Default,
        White,
        Black
    }

    enum CheckmateState
    {
        MoveAvailable,
        NoMoveAvailable
    }
}
