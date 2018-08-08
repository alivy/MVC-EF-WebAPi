using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ContractPlansService : ServiceBase<Q_ContractPlans>
    {
       
    }

    public class Q_ContractPlans : ModelBase
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
