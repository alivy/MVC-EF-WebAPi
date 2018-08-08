using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ContractService : ServiceBase<Q_Contract>
    {
       
    }

    public class Q_Contract : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ContractNumber{ get; set; }
        public string ContractName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? StartTime{ get; set; }
        public DateTime? EndTime{ get; set; }
        public decimal? TotalAmount{ get; set; }
        public int? State{ get; set; }
        public int? Days{ get; set; }
        public int? RepayType{ get; set; }
        public string Safes{ get; set; }
        public string ContractType{ get; set; }
        public string ContractDescription{ get; set; }
        public string RiskDescription{ get; set; }
        public int ProjectID{ get; set; }
        public int BidType{ get; set; }
        public int LoanUid{ get; set; }
    }
}
