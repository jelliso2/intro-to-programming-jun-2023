namespace Games;

public class BowlingGame
{
    private readonly List<Player> _players = new();

    public void AddPlayer(string name, int score)
    {
        GuardForValidScore(score);
        GuardForPlayerExisting(name);

        _players.Add(new Player(name, score));

        // store some kind of list of players and their scores
        // unless a player with that same name already exists.
        // in that case, punch them in the nose.
    }

    private void GuardForPlayerExisting(string name)
    {
        if (PlayerExists(name))
        {
            throw new PlayerAlreadyAddedToGameException();
        }
    }

    private static void GuardForValidScore(int score)
    {
        if (score < 0 || score > 300) { throw new InvalidBowlingScoreException(); }
    }

    private bool PlayerExists(string name)
    {
        return _players.Any(p => p.Name.Trim().ToLowerInvariant() == name.Trim().ToLowerInvariant());
    }

    internal List<Player> GetPlayers()
    {
        return _players;
    }


}


public record Player(string Name,int score);
