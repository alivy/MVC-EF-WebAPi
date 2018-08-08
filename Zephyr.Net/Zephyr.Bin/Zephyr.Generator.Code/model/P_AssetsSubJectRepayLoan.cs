using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_AssetsSubJectRepayLoanService : ServiceBase<P_AssetsSubJectRepayLoan>
    {
       
    }

    public class P_AssetsSubJectRepayLoan : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string LoanNumber{ get; set; }
        public int? RePayUid{ get; set; }
        public int? SubjectPayId{ get; set; }
        public int? RePayPeriods{ get; set; }
        public DateTime? RePayTime{ get; set; }
        public DateTime? ActualRepayTime{ get; set; }
        public decimal? CurPrincipal{ get; set; }
        public decimal? CurInterest{ get; set; }
        public int? OverdueDay{ get; set; }
        public decimal? OverDuePenalty{ get; set; }
        public string ContractNumber{ get; set; }
        public string RePayNumber{ get; set; }
        public int? RePayState{ get; set; }
    }
}
