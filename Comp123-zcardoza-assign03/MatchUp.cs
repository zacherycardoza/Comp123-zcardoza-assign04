namespace Comp123_zcardoza_assign03
{
    internal class MatchUp
    {
        private static int NextId = 1;
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }

        public MatchUp()
        {
            PlayerId = NextId++;
        }

        public MatchUp(string name, Team team)
        {
            Name = name;
            Team = team;
            PlayerId = NextId++;
        }
    }
}