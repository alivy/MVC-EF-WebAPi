using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ModifyRecordService : ServiceBase<Q_ModifyRecord>
    {
       
    }

    public class Q_ModifyRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int TypeId{ get; set; }
        public long BatchNo{ get; set; }
        public int RelationId{ get; set; }
        public DateTime AddTime{ get; set; }
        public int DataType{ get; set; }
        public int State{ get; set; }
    }
}
