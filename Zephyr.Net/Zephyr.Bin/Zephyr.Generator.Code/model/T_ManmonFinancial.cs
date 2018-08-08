using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ManmonFinancialService : ServiceBase<T_ManmonFinancial>
    {
       
    }

    public class T_ManmonFinancial : ModelBase
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public int GodID{ get; set; }
        public string FinancialName{ get; set; }
        public string FinancialRemark{ get; set; }
    }
}
