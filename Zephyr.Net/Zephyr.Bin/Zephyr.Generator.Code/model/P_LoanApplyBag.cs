using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_LoanApplyBagService : ServiceBase<P_LoanApplyBag>
    {
       
    }

    public class P_LoanApplyBag : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string Title{ get; set; }
        public string Days{ get; set; }
        public decimal TotalAmount{ get; set; }
        public decimal SurplusNum{ get; set; }
        public decimal LockNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int AuditUid{ get; set; }
        public string AuditOpinion{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public int ReviewUid{ get; set; }
        public string ReviewOpinion{ get; set; }
        public DateTime? ReviewTime{ get; set; }
        public int State{ get; set; }
    }
}
