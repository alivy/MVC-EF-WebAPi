using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_JXWithdrawalService : ServiceBase<T_JXWithdrawal>
    {
       
    }

    public class T_JXWithdrawal : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal RePayNum{ get; set; }
        public decimal? LockNum{ get; set; }
        public decimal? EnableNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
