using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_LoanApplyRecordService : ServiceBase<L_LoanApplyRecord>
    {
       
    }

    public class L_LoanApplyRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal Amount{ get; set; }
        public int Periods{ get; set; }
        public int? LoanUsageId{ get; set; }
        public string LoanNumber{ get; set; }
        public string Description{ get; set; }
        public DateTime Addtime{ get; set; }
        public int ApplyType{ get; set; }
        public int State{ get; set; }
    }
}
