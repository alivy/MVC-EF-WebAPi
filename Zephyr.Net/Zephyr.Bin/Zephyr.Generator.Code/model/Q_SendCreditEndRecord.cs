using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SendCreditEndRecordService : ServiceBase<Q_SendCreditEndRecord>
    {
       
    }

    public class Q_SendCreditEndRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? PayUid{ get; set; }
        public int? LoanUid{ get; set; }
        public string InvestNum{ get; set; }
        public string out_card_no{ get; set; }
        public string in_card_no{ get; set; }
        public string assets_no{ get; set; }
        public string auth_code{ get; set; }
        public string serial_no{ get; set; }
        public string third_reserved{ get; set; }
        public string BatchNo{ get; set; }
        public string Channel{ get; set; }
        public string OrgOrderId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int State{ get; set; }
    }
}
