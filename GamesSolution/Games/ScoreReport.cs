namespace Games;

public class ScoreReport
{
    public List<Player> Winners { get; init; } = new();
    public double Average { get; init; }
    public List<Player> Losers { get; init; } = new();

    public string Message { get; init; } = string.Empty;
}
