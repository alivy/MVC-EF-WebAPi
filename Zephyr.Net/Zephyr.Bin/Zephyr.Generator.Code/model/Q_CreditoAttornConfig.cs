using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CreditoAttornConfigService : ServiceBase<Q_CreditoAttornConfig>
    {
       
    }

    public class Q_CreditoAttornConfig : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int MinDay{ get; set; }
        public int RaisingPeriod{ get; set; }
        public decimal FeeRate{ get; set; }
        public int PasswordStatus{ get; set; }
    }
}
