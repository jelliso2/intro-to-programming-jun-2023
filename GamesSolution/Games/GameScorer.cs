namespace Games;

public class GameScorer
{


    public ScoreReport GenerateScoreReportFor(BowlingGame game)
    {
        // Pre conditions - all of the scores are in the valid ranges and there are no duplicate names.
        // Winners, Losers, Average



        // To Find the winners....
        if(game.GetPlayers().Count < 2)
        {
            throw new InvalidGameException();
        }
        var players = game.GetPlayers();

        int highScore = players.Max(p => p.score);
        int lowScore = players.Min(p => p.score);


        return new ScoreReport
        {
            Winners = players.Where(p=>p.score == highScore).ToList(),
            Losers = highScore == lowScore ? new() : players.Where(p=>p.score == lowScore).ToList(),
            Average = players.Average(p=>p.score)
        };
    }
}