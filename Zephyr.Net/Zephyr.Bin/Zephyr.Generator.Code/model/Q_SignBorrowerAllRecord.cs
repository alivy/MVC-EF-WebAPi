using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SignBorrowerAllRecordService : ServiceBase<Q_SignBorrowerAllRecord>
    {
       
    }

    public class Q_SignBorrowerAllRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? Uid{ get; set; }
        public string AccountID{ get; set; }
        public decimal? Amount{ get; set; }
        public string Out_serial_no{ get; set; }
        public string Start_time{ get; set; }
        public string End_time{ get; set; }
        public DateTime? Addtime{ get; set; }
        public int? Sign_flag{ get; set; }
        public string Interface_type{ get; set; }
    }
}
