using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Interfaces;

namespace COM_POC_1.Models
{
    public class Theme
    {
        public int ThemeId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public List<PowerTag> PowerTags { get; set; }
        public List<IFocus> Attention { get; set; }
        public List<IFocus> LoseFocus { get; set; }
        public int? RiftId { get; set; }
    }

    public enum Type
    {
        Mythos,
        Logos
    }
}
