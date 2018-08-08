using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SubjectLendRecordService : ServiceBase<Q_SubjectLendRecord>
    {
       
    }

    public class Q_SubjectLendRecord : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int LoanUid{ get; set; }
        public int SubjectBidId{ get; set; }
        public int InvestUid{ get; set; }
        public string LendOrder{ get; set; }
        public decimal LendNum{ get; set; }
        public int LendState{ get; set; }
        public DateTime AddTime{ get; set; }
        public string SerialNumber{ get; set; }
        public string BatchNo{ get; set; }
        public decimal LvCharge{ get; set; }
    }
}
