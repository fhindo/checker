namespace ProjectGame.Pages;
public class CheckerBoard
{
    public int[,] BaordArray {get; set;}
    public int Column {get; set;}
    public int Row {get; set;}


    public CheckerBoard (int column, int row)
    {
        Column = column;
        Row = row;
    }
}