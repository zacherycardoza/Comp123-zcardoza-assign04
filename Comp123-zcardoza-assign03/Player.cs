using System.Threading;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Comp123_zcardoza_assign03
{
    public class Player
    {
        [JsonIgnore]
        private static int NextId = 1;
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public Team Team { get; set; }

        public Player()
        {
            PlayerId = NextId++;
        }

        public Player(string name, Team team)
        {
            Name = name;
            Team = team;
            PlayerId = NextId++;
        }
    }
}
