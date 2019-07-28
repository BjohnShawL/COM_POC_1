using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Interfaces;

namespace COM_POC_1.Models
{
    public class Attention : IFocus
    {
        public int Id { get; set; }
        public bool Marked { get; set; }
        public Theme Theme { get; set; }
        public int ThemeId { get; set; }
    }
}
