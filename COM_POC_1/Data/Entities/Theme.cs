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
        public Archetype Archetype { get; set; }
        public string Description { get; set; }
        public Type Type { get; set; }
        public List<PowerTag> PowerTags { get; set; }
        public ICollection<Attention> Attention { get; set; }
        public ICollection<Crack> Cracks { get; set; }
        public ICollection<Fade> Fades { get; set; }
        public ICollection<BuildUp> BuildUps { get; set; }
        public int? RiftId { get; set; }
    }

    public enum Type
    {
        Mythos,
        Logos
    }

    public enum Archetype
    {
        Adaption,
        Bastion,
        Divination,
        Expression,
        Mobility,
        Relic,
        Subversion,
        DefiningEvent,
        DefiningRelationship,
        Mission,
        Personality,
        Possessions,
        Routine,
        Training
    }

}
