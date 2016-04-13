using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sciencetific_Calc
{
    public class PieceTracker
    {
        private Piece piece;
        private Coordinate coordinate;
        private Player1 player;

        public Piece Piece
        {
            get
            {
                return piece;
            }
            set
            {
                piece = value;
            }
        }

        public Coordinate Coordinate
        {
            get
            {
                return coordinate;
            }
            set
            {
                coordinate = value;
            }
        }

        public Player1 Player
        {
            get
            {
                return player;
            }
            set
            {
                player = value;
            }
        }
    }
}

