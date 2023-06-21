

namespace Games.Test;

public class ScoringAnInvalidGame
{
    [Fact]
    public void GamesMustHAveAtLeastTwoPlayers()
    {
        var game = new BowlingGame();

        game.AddPlayer("Jeff", 99);

        var scorer = new GameScorer();

        Assert.Throws<InvalidGameException>(() => scorer.GenerateScoreReportFor(game));
    }


    [Fact]
    public void GamesCannotHaveNoPlayers()
    {
        var game = new BowlingGame();

       

        var scorer = new GameScorer();

        Assert.Throws<InvalidGameException>(() => scorer.GenerateScoreReportFor(game));
    }
}
