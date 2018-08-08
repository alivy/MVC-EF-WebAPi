using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ScoreOrderService : ServiceBase<Q_ScoreOrder>
    {
       
    }

    public class Q_ScoreOrder : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int ProductId{ get; set; }
        public int BuyNum{ get; set; }
        public int ScorePrice{ get; set; }
        public int UsePoints{ get; set; }
        public string OrderNum{ get; set; }
        public int OrderState{ get; set; }
        public int InvestType{ get; set; }
        public DateTime AddTime{ get; set; }
        public string TrueName{ get; set; }
        public string PhoneNum{ get; set; }
        public string DetailAddress{ get; set; }
        public DateTime? PayTime{ get; set; }
    }
}
