using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_POC_1.Models
{
    public class Player
    {
        public int PlayerId { get; set; } 
        public string Name { get; set; }
        public ICollection<Character> Characters { get; set; } 

    }
}
