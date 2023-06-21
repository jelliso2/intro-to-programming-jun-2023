

namespace Games.Test;

public class ThinkingAboutTheGame
{
    [Fact]
    public void DuplicateNamesAreNotAllowed()
    {
        //Given
        var game = new BowlingGame();

        //when
        game.AddPlayer("Jim", 120);
        //game.AddPlayer("Jim", 120);

        //Then??


        Assert.Throws<PlayerAlreadyAddedToGameException>(() => game.AddPlayer("Jim", 200));
    }

    [Theory]
    [InlineData(-1)]
    public void InvalidScoresThrowAnException(int invalidScore)
    {
        var game = new BowlingGame();



        Assert.Throws<InvalidBowlingScoreException>(() =>
            game.AddPlayer("Jim", invalidScore)
        );



    }

}
