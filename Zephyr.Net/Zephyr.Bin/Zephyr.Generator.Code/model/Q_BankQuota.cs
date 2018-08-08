using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BankQuotaService : ServiceBase<Q_BankQuota>
    {
       
    }

    public class Q_BankQuota : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string BankName{ get; set; }
        public string BankCode{ get; set; }
        public string BankLogo{ get; set; }
        public string BankWeiXinLogo{ get; set; }
        public decimal? SingleNum{ get; set; }
        public decimal? SingleDay{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int State{ get; set; }
    }
}
