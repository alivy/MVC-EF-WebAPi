using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_PageVisitRecordService : ServiceBase<S_PageVisitRecord>
    {
       
    }

    public class S_PageVisitRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Ip{ get; set; }
        public string Browser{ get; set; }
        public string ClientId{ get; set; }
        public int? UserId{ get; set; }
        public string VisitUrl{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string ClientUserId{ get; set; }
        public string OpenId{ get; set; }
    }
}
