using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MammonUserOptMessageService : ServiceBase<T_MammonUserOptMessage>
    {
       
    }

    public class T_MammonUserOptMessage : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public int? OptState{ get; set; }
        public int? GodID{ get; set; }
        public int? FinancialID{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string UserName{ get; set; }
        public string Birthday{ get; set; }
        public string UserImg{ get; set; }
    }
}
