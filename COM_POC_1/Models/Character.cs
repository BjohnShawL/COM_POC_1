using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_POC_1.Models
{
    public class Character
    {
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public List<Rift> Rifts { get; set; }
        public List<Theme> Themes { get; set; }
        public Player Player { get; set; }
        public int PlayerId { get; set; }
    }
}
