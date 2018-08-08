using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ContractPlans : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string PlanNumber{ get; set; }
        public string PlanName{ get; set; }
        public string ContractNumber{ get; set; }
        public int? PlanPeriods{ get; set; }
        public decimal? Amount{ get; set; }
        public int? Days{ get; set; }
        public DateTime? LoanTime{ get; set; }
        public int? State{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
