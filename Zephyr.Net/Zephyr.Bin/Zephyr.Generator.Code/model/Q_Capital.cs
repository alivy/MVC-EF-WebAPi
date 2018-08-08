using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CapitalService : ServiceBase<Q_Capital>
    {
       
    }

    public class Q_Capital : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal Total{ get; set; }
        public decimal Wait{ get; set; }
        public decimal Lock{ get; set; }
        public decimal EnableNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
