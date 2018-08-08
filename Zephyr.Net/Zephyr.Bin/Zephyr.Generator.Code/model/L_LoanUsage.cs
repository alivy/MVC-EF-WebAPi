using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_LoanUsageService : ServiceBase<L_LoanUsage>
    {
       
    }

    public class L_LoanUsage : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public int UsageType{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
