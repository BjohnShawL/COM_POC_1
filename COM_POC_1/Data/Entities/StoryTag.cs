using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_POC_1.Data.Entities
{
    public class StoryTag
    {
        public int StoryTagId { get; set; }
        public int Modifier { get; set; }
        public bool PosNeg { get; set; }
        public Scope scope { get; set; }
        public int McId { get; set; }
        public int GameId { get; set; }

        public enum Scope
        {
            Instant,
            Temporary,
            Permanent
        }
    }
}
