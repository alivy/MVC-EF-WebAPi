using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_LoanComInfo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string ComName{ get; set; }
        public string ComNumber{ get; set; }
        public decimal ReglCapital{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public string AuditOpinion{ get; set; }
    }
}
