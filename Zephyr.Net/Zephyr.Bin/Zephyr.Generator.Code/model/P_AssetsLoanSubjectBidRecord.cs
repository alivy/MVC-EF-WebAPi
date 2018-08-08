using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_AssetsLoanSubjectBidRecordService : ServiceBase<P_AssetsLoanSubjectBidRecord>
    {
       
    }

    public class P_AssetsLoanSubjectBidRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanApplyId{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectBidId{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal Scale{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
