﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciencetific_Calc
{
    class Pawn : Piece
    {
        public override bool Move(Coordinate oldCoordinate, Coordinate newCoordinate)
        {
            bool checkMove = false;

            int moveDirection = 0;

            List<PieceTracker> pieceListAtNewCoordinate = (from piece in chessBoard.game.PieceList
                                                           where piece.Coordinate.XCoordinate.Equals(newCoordinate.XCoordinate)
                                                           & piece.Coordinate.YCoordinate.Equals(newCoordinate.YCoordinate)
                                                           select piece).ToList();

            if (chessBoard.game.CurrentPlayer == Player1.White)
            {
                moveDirection = 1;
            }

            else
            {
                moveDirection = -1;
            }

            if (oldCoordinate.XCoordinate == newCoordinate.XCoordinate && oldCoordinate.YCoordinate + moveDirection == newCoordinate.YCoordinate)
            {
                if (pieceListAtNewCoordinate.Count == 0)
                {
                    checkMove = true;
                }
            }

            else if (moveDirection == 1 && oldCoordinate.YCoordinate == 1 && newCoordinate.YCoordinate == oldCoordinate.YCoordinate + 2)
            {
                checkMove = true;
            }

            else if (moveDirection == -1 && oldCoordinate.YCoordinate == 6 && newCoordinate.YCoordinate == oldCoordinate.YCoordinate - 2)
            {
                checkMove = true;
            }

            else if (moveDirection == 1)
            {
                if ((newCoordinate.XCoordinate - oldCoordinate.XCoordinate == 1 && newCoordinate.YCoordinate - oldCoordinate.YCoordinate == 1)
                        || (oldCoordinate.XCoordinate - newCoordinate.XCoordinate == 1 && newCoordinate.YCoordinate - oldCoordinate.YCoordinate == 1))
                {
                    if (pieceListAtNewCoordinate.Count == 1)
                    {
                        checkMove = pawnCannotCheckKing(checkMove, pieceListAtNewCoordinate);
                    }
                }
            }

            else if (moveDirection == -1)
            {
                if ((oldCoordinate.XCoordinate - newCoordinate.XCoordinate == 1 && oldCoordinate.YCoordinate - newCoordinate.YCoordinate == 1)
                    || (newCoordinate.XCoordinate - oldCoordinate.XCoordinate == 1 && oldCoordinate.YCoordinate - newCoordinate.YCoordinate == 1))
                {
                    if (pieceListAtNewCoordinate.Count == 1)
                    {
                        checkMove = pawnCannotCheckKing(checkMove, pieceListAtNewCoordinate);
                    }
                }

            }

            return checkMove;
        }

        private static bool pawnCannotCheckKing(bool checkMove, List<PieceTracker> pieceListAtNewCoordinate)
        {
            if (pieceListAtNewCoordinate[0].Piece.Name.Contains("King"))
            {
                checkMove = false;
            }

            else
            {
                checkMove = true;
            }
            return checkMove;
        }
    }
}