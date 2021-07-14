using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comp123_zcardoza_assign03
{
    class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public List<Player> Roster { get; set; }
    }
}
