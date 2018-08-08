using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_AnniversaryRedMoneyService : ServiceBase<T_AnniversaryRedMoney>
    {
       
    }

    public class T_AnniversaryRedMoney : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public decimal? RedMoney{ get; set; }
        public string Remark{ get; set; }
        public int? State{ get; set; }
        public int? TypeId{ get; set; }
    }
}
