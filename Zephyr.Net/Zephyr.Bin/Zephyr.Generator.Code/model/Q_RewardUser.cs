using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RewardUserService : ServiceBase<Q_RewardUser>
    {
       
    }

    public class Q_RewardUser : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? UserId{ get; set; }
        public int? Num{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? ProductId{ get; set; }
        public int? TotalNum{ get; set; }
    }
}
