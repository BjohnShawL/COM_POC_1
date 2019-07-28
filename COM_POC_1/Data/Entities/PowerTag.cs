using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

namespace COM_POC_1.Models
{
    public class PowerTag
    {
        
        public int PowerTagId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsDynamite { get; set; }
    }
}
