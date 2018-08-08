using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class D_Area : IAggregateRoot
    {

        public string areaCode{ get; set; }
        public int? areaLv{ get; set; }
        public string areaName{ get; set; }
        public string parentCode{ get; set; }
    }
}
