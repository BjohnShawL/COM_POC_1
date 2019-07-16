using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COM_POC_1.Models;

namespace COM_POC_1.Interfaces
{
    public interface IThemeType
    {
        List<PowerTag> PowerTags { get; set; }
        string Weakness { get; set; }

    }
}
