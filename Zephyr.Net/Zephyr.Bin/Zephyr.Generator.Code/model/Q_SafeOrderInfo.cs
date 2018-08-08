using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SafeOrderInfoService : ServiceBase<Q_SafeOrderInfo>
    {
       
    }

    public class Q_SafeOrderInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? UserId{ get; set; }
        public string OrderNumber{ get; set; }
        public string OrderId{ get; set; }
        public string quoteNo{ get; set; }
        public decimal? PayAmount{ get; set; }
        public string ReqTimestamp{ get; set; }
        public int? State{ get; set; }
        public int BackState{ get; set; }
        public decimal CiBackTotal{ get; set; }
        public decimal CiBackLv{ get; set; }
        public decimal CiUserBackLv{ get; set; }
        public decimal CiBackResult{ get; set; }
        public decimal CiUserBackResult{ get; set; }
        public decimal BiBackTotal{ get; set; }
        public decimal BiBackLv{ get; set; }
        public decimal BiUserBackLv{ get; set; }
        public decimal BiBackResult{ get; set; }
        public decimal BiUserBackResult{ get; set; }
        public decimal BackTotal{ get; set; }
        public decimal UserBackTotal{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
