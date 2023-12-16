using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public class NormalMove : Move
    {
        public override MoveType Type => MoveType.Normal;
        public override Positions FromPos { get; }
        public override Positions ToPos { get; }

        public NormalMove(Positions from, Positions to)
        {
            FromPos = from;
            ToPos = to;
        }

        public override void Execute(Board board) //implements the move
        {
            Piece piece = board[FromPos];
            board[ToPos] = piece;
            board[FromPos] = null;
            piece.HasMoved = true;
        }
    }
}
