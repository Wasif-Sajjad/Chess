namespace ChessLogic
{
    public abstract class Move
    {
        public abstract MoveType Type { get; }
        public abstract Positions FromPos { get;}
        public abstract Positions ToPos { get; }

        public abstract void Execute(Board board);
        // Might need to implement a faster method for Computer generated player!!!!!! (For IsLegal)
        public virtual bool IsLegal(Board board)
        {
            Player player = board[FromPos].Color;
            Board boardCopy = board.Copy();
            Execute(boardCopy);
            return !boardCopy.IsInCheck(player);
        }
    }
}
