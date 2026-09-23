public class Player
{
    public string Nickname { get; set; } = "Guest";
    private int _rating;
    public int Rating
    {
        get { return _rating; }
        set
        {
            if (value >= 0)
            {
                _rating = value;
            }
        }
    }
}
