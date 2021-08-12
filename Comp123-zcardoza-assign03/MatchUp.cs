namespace Comp123_zcardoza_assign03
{
    internal class Matchup
    {
        public static int NextId = 1;
        public int MatchupId { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }

        public Matchup()
        {
            MatchupId = NextId++;
        }
        public Matchup(Team homeTeam, Team awayTeam)
        {
            MatchupId = NextId++;
            HomeTeam = homeTeam;
            AwayTeam = awayTeam;
        }
    }
}