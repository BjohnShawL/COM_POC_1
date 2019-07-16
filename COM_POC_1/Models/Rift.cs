using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_POC_1.Models
{
    public class Rift
    {
        public int RiftId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Mystery { get; set; }
        public bool CurrentlyActive { get; set; }

        public Character Character { get; set; }
        public int CharacterId { get; set; }
    }
}
