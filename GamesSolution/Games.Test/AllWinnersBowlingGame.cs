

namespace Games.Test;

public class AllWinnersBowlingGame
{
    private readonly List<Player> _expectedWinners;
    private readonly List<Player> _expectedLosers;
    private readonly ScoreReport _report;



    public AllWinnersBowlingGame()
    {
        // Given 
        var game = new BowlingGame();
        var p1 = new Player("Jeff", 287);
        var p2 = new Player("Stacey", 287);
        game.AddPlayer(p1.Name, p1.score);
        game.AddPlayer(p2.Name, p2.score);



        _expectedWinners = new List<Player> { p1,p2 };
        _expectedLosers = new List<Player>() {  };



        var scorer = new GameScorer();



        // When I ask for the score
        _report = scorer.GenerateScoreReportFor(game);
    }

    [Fact]
    public void NoLosers()
    {
        Assert.Empty(_expectedLosers);
    }



    [Fact]
    public void AllWinners()
    {
        Assert.Equal(_expectedWinners, _report.Winners);
    }

}
