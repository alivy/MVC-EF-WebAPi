using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AutoBidRecordService : ServiceBase<Q_AutoBidRecord>
    {
       
    }

    public class Q_AutoBidRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public string LoanNumber{ get; set; }
        public int? SubjectType{ get; set; }
        public string SubjectTitle{ get; set; }
        public int? Day{ get; set; }
        public decimal? AutoNum{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? State{ get; set; }
        public int? OperationUid{ get; set; }
    }
}
