namespace ProjectGame.Pages;
public class CheckerClass
{
    public int Row { get; set; }
    public int Column { get; set; }
    public string Color { get; set; }
    public CheckerDirection Direction { get; set; }


    public List<int> rowsOptions = new List<int>();
    public List<int> coulmnsOptions = new List<int>();
    public void CheckCheckerPosition()
    {
        rowsOptions.Clear();
        coulmnsOptions.Clear();
        if (Row != null && Column != null)
        {
            rowsOptions.Add(Row + (1 * (Direction == CheckerDirection.Down ? 1 : -1)));
            coulmnsOptions.Add(Column - 1);
            coulmnsOptions.Add(Column + 1);
        }
    }

    public void MoveChecker(int row, int column)
    {
        bool canMoveTo = rowsOptions.Contains(row) && coulmnsOptions.Contains(column);
        if (!canMoveTo)
            return;
        Column = column;
        Row = row;
    }

}

public enum CheckerDirection
{
    Down, Up, Both
}