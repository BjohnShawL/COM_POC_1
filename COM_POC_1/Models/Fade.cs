using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Interfaces;

namespace COM_POC_1.Models
{
    public class Fade :IFocus
    {
        public bool Marked { get; set; }
        public Theme Theme { get; set; }
        public int ThemeId { get; set; }
        public string Name { get; set; }


        public Fade()
        {
            Marked = false;
            Name = "Fade";
        }
    }
}
