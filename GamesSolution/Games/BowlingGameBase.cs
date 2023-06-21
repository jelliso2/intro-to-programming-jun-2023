namespace Games
{
    public abstract class BowlingGameBase
    {
        private readonly List<Player> _players = new();
        protected abstract void GuardForValidScore(int score);

        public void AddPlayer(string name, int score)
        {
            GuardForValidScore(score);
            GuardForPlayerExisting(name);

            _players.Add(new Player(name, score));

            // store some kind of list of players and their scores
            // unless a player with that same name already exists.
            // in that case, punch them in the nose.
        }

        internal List<Player> GetPlayers()
        {
            return _players;
        }

        private void GuardForPlayerExisting(string name)
        {
            if (PlayerExists(name))
            {
                throw new PlayerAlreadyAddedToGameException();
            }
        }

        private bool PlayerExists(string name)
        {
            return _players.Any(p => p.Name.Trim().ToLowerInvariant() == name.Trim().ToLowerInvariant());
        }
    }
}