using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_LoanComInfoService : ServiceBase<L_LoanComInfo>
    {
       
    }

    public class L_LoanComInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string ComName{ get; set; }
        public string ComNumber{ get; set; }
        public decimal ReglCapital{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public string AuditOpinion{ get; set; }
    }
}
