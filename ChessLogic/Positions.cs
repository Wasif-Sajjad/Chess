namespace ChessLogic
{
    public class Positions
    {
        public int Row { get; }
        public int Column { get; }

        public Positions(int row, int column)
        {
            Row = row;
            Column = column;
        }

        public Player SquareColor()
        {
            if((Row + Column) % 2 == 0)
            {
                return Player.White;
            }

            return Player.Black;
        }

        public override bool Equals(object obj)
        {
            return obj is Positions positions &&
                   Row == positions.Row &&
                   Column == positions.Column;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Row, Column);
        }

        public static bool operator ==(Positions left, Positions right)
        {
            return EqualityComparer<Positions>.Default.Equals(left, right);
        }

        public static bool operator !=(Positions left, Positions right)
        {
            return !(left == right);
        }

        public static Positions operator +(Positions pos, Direction dir)
        {
            return new Positions(pos.Row + dir.RowDelta, pos.Column + dir.ColumnDelta);
        }
    }
}
