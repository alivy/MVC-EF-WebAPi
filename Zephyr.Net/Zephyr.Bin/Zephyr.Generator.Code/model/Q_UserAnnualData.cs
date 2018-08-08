using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_UserAnnualData : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int Year{ get; set; }
        public decimal TotalInvest{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
    }
}
