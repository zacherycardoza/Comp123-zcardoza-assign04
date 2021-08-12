using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Comp123_zcardoza_assign03
{
    public class Team
    {
        [JsonIgnore]
        public static int NextId = 1;
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Player> Roster { get; set; }

        public Team()
        {
            TeamId = NextId++;
        }
        public Team(string name)
        {
            Name = name;
            TeamId = NextId++;
        }
    }
}
