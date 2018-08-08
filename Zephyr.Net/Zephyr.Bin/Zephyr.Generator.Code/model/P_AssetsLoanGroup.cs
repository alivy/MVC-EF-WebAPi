using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_AssetsLoanGroupService : ServiceBase<P_AssetsLoanGroup>
    {
       
    }

    public class P_AssetsLoanGroup : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectPayId{ get; set; }
        public int BagId{ get; set; }
        public int LoanApplyId{ get; set; }
        public decimal Scale{ get; set; }
        public int State{ get; set; }
    }
}
