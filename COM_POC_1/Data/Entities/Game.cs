using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Models;

namespace COM_POC_1.Data.Entities
{
    public class Game
    {
        public int GameId { get; set; }
        public string Name { get; set; }
        public List<Player> Players { get; set; }
        public Mc Mc { get; set; }
        public List<StoryTag> StoryTags { get; set; }
    }
}
