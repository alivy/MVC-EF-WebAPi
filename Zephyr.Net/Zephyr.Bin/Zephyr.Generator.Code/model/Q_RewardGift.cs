using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RewardGiftService : ServiceBase<Q_RewardGift>
    {
       
    }

    public class Q_RewardGift : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int ProductId{ get; set; }
        public string GiftName{ get; set; }
        public int GiftNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int OrderNum{ get; set; }
        public int MaxNum{ get; set; }
        public int MinNum{ get; set; }
    }
}
