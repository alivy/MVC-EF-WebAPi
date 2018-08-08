using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_ContinueInvestService : ServiceBase<T_ContinueInvest>
    {
       
    }

    public class T_ContinueInvest : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal RePayNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public decimal? Lock{ get; set; }
        public decimal? EnableNum{ get; set; }
        public decimal UsableNum{ get; set; }
    }
}
