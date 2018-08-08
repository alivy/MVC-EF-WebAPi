using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditoAttornRecordService : ServiceBase<Q_CreditoAttornRecord>
    {
       
    }

    public class Q_CreditoAttornRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int UserId{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectId{ get; set; }
        public int SubjectBidId{ get; set; }
        public int InvestNum{ get; set; }
        public decimal TransferNum{ get; set; }
        public int SurplusPeriods{ get; set; }
        public string AuditOpinion{ get; set; }
        public int AuditUid{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public DateTime ApplyTime{ get; set; }
        public int State{ get; set; }
    }
}
