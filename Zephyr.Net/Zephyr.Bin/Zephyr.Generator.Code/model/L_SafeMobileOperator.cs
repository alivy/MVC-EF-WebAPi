using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_SafeMobileOperatorService : ServiceBase<L_SafeMobileOperator>
    {
       
    }

    public class L_SafeMobileOperator : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string PhonePwd{ get; set; }
        public string MobileNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? AuthTime{ get; set; }
        public int IsDel{ get; set; }
        public int? State{ get; set; }
        public int Uid{ get; set; }
    }
}
