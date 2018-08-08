using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_CreditoSubjectPay : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string CreditoLoadNumber{ get; set; }
        public string LoanNumber{ get; set; }
        public decimal FloatNum{ get; set; }
        public decimal FeeNum{ get; set; }
    }
}
