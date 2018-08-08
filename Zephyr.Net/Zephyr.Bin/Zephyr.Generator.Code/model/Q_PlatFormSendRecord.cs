using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_PlatFormSendRecordService : ServiceBase<Q_PlatFormSendRecord>
    {
       
    }

    public class Q_PlatFormSendRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int FormUid{ get; set; }
        public string OrderNumber{ get; set; }
        public string GoodsMark{ get; set; }
        public decimal GoodSprice{ get; set; }
        public string GoodsName{ get; set; }
        public string Status{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? ReState{ get; set; }
        public string ReMsg{ get; set; }
    }
}
