namespace Games;

public class BowlingGame : BowlingGameBase
{
    protected override void GuardForValidScore(int score)
    {
        if (score < 0 || score > 300) { throw new InvalidBowlingScoreException(); }
    }
}


public record Player(string Name,int score);
