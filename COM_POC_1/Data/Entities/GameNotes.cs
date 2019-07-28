using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_POC_1.Data.Entities
{
    public class GameNotes
    {
        public int GameNotesId { get; set; }
        public int CreatorId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedOn { get; set; }
        public int GameId { get; set; }
    }
}
