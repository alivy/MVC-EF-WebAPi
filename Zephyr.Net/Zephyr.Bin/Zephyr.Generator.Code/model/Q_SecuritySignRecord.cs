using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SecuritySignRecordService : ServiceBase<Q_SecuritySignRecord>
    {
       
    }

    public class Q_SecuritySignRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public decimal Add_SignAmount{ get; set; }
        public decimal Make_SignAmount{ get; set; }
        public decimal SignAomount{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? SignType{ get; set; }
    }
}
