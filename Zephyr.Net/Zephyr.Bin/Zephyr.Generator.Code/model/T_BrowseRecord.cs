using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_BrowseRecordService : ServiceBase<T_BrowseRecord>
    {
       
    }

    public class T_BrowseRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public string TjrId{ get; set; }
        public string Url{ get; set; }
        public string ReferUrl{ get; set; }
        public int BroTime{ get; set; }
        public DateTime? InTime{ get; set; }
        public DateTime? OutTime{ get; set; }
        public string System{ get; set; }
        public string Browser{ get; set; }
        public int? ActivityNO{ get; set; }
    }
}
