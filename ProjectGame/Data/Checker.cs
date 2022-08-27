namespace ProjectGame.Pages;
using ProjectGame.Data;
public class CheckerClass
{
    public int Row { get; set; }
    public int Column { get; set; }
    public string Color { get; set; }
    public CheckerDirection Direction { get; set; }


    // these lists are to store the value of the cell that the checker can move to
    public List<int> rowsOptions = new List<int>();
    public List<int> coulmnsOptions = new List<int>();
    
    // public CheckerClass? activeChecker = null;

    

    // public void CheckCheckerPosition()
    // {
    //     rowsOptions.Clear();
    //     coulmnsOptions.Clear();
    //     if (activeChecker != null)
    //             {
    //             Console.WriteLine(Row);
    //             Console.WriteLine(Column);
    //             Console.WriteLine(Color);
    //             Console.WriteLine(Direction);
    //             rowsOptions.Add(Row + (1* (activeChecker.Direction == CheckerDirection.Down ? 1 : -1)));
    //             coulmnsOptions.Add(Column -1);
    //             coulmnsOptions.Add(Column +1);
    //             }
        
    // }

    //  void MoveChecker( int row, int column )
    // {
    //     Console.WriteLine( "MoveChecker" );
    //     bool canMoveHere = rowsPossible.Contains( row ) && columnsPossible.Contains( column );
    //     if( !canMoveHere )
    //     {
    //         return;
    //     }
    //     if( activeChecker != null )
    //     {
    //         activeChecker.Column = column;
    //         activeChecker.Row = row;
    //         activeChecker = null;
    //         EvaluateCheckerSpots();
    //     }
    
    // }

    

}

public enum CheckerDirection
{
    Down, Up, Both
}

















    // public void CheckCheckerPosition()
    // {
    //     rowsOptions.Clear();
    //     coulmnsOptions.Clear();
    //     if (Row != null && Column != null)
    //     {
    //         rowsOptions.Add(Row + (1 * (Direction == CheckerDirection.Down ? 1 : -1)));
    //         coulmnsOptions.Add(Column - 1);
    //         coulmnsOptions.Add(Column + 1);
    //     }
    // }

    // public void MoveChecker(int row, int column)
    // {
    //     bool canMoveTo = rowsOptions.Contains(row) && coulmnsOptions.Contains(column);
    //     if (!canMoveTo)
    //         return;
    //     Column = column;
    //     Row = row;
    // }
