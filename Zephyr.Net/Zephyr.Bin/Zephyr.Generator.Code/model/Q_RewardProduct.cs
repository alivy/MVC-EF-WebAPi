using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RewardProductService : ServiceBase<Q_RewardProduct>
    {
       
    }

    public class Q_RewardProduct : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Remark{ get; set; }
    }
}
