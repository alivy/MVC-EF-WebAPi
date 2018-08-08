using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_SafeSocialSecurityService : ServiceBase<L_SafeSocialSecurity>
    {
       
    }

    public class L_SafeSocialSecurity : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string SocialSecurityNum{ get; set; }
        public string Account{ get; set; }
        public string Pwd{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime AuthTime{ get; set; }
        public int State{ get; set; }
    }
}
