using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_AssetsSubJectRepayRecordService : ServiceBase<P_AssetsSubJectRepayRecord>
    {
       
    }

    public class P_AssetsSubJectRepayRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string LoanNumber{ get; set; }
        public int? SubjectPayId{ get; set; }
        public int? RePayPeriods{ get; set; }
        public DateTime? RePayTime{ get; set; }
        public decimal? CurPrincipal{ get; set; }
        public decimal? CurInterest{ get; set; }
        public int? OverdueDay{ get; set; }
        public decimal? OverDuePenalty{ get; set; }
        public decimal? TotalNum{ get; set; }
        public decimal? SurplusNum{ get; set; }
        public int? RePayState{ get; set; }
    }
}
