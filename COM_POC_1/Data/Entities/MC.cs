using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures.Internal;

namespace COM_POC_1.Data.Entities
{
    public class Mc
    {
        public int McId { get; set; }
        public string Name { get; set; }
        public List<Character> NpcList { get; set; }
        public List<GameNotes> GameNotes { get; set; }
        public List<Game> Games { get; set; }

    }
}
