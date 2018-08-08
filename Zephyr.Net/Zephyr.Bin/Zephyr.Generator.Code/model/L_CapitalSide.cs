using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_CapitalSide : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ProjectName{ get; set; }
        public string CapitalType{ get; set; }
        public string InvestRange{ get; set; }
        public string InvestDay{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? EditTime{ get; set; }
        public int? VisitCount{ get; set; }
        public string ContentDescription{ get; set; }
    }
}
