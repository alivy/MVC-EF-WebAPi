using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ManmonFinancial : IAggregateRoot
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public int GodID{ get; set; }
        public string FinancialName{ get; set; }
        public string FinancialRemark{ get; set; }
    }
}
