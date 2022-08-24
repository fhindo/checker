namespace ProjectGame.Pages;
public class CheckerClass
{
    public int Row { get; set; }
    public int Column { get; set; }
    public string Color { get; set; }
    public CheckerDirection Direction { get; set; }

    public bool CheckPosition()
    {
        return true;
    }

}

public enum CheckerDirection
{
    Down, Up, Both
}