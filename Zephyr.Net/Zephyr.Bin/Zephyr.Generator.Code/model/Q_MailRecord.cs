using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_MailRecordService : ServiceBase<Q_MailRecord>
    {
       
    }

    public class Q_MailRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int UId{ get; set; }
        public int Category{ get; set; }
        public string Content{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Ip{ get; set; }
        public string Email{ get; set; }
    }
}
