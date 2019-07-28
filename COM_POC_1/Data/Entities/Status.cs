using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_POC_1.Data.Entities
{
    public class Status
    {
        public int StatusId { get; set; }
        public int Modifier { get; set; }
        public bool PosNeg { get; set; }
        public string Description { get; set; }
    }
}
