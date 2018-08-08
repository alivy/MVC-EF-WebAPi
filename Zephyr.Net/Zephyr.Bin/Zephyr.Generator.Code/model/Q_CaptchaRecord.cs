using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CaptchaRecordService : ServiceBase<Q_CaptchaRecord>
    {
       
    }

    public class Q_CaptchaRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Mobile{ get; set; }
        public string Code{ get; set; }
        public int ErrorCount{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public string AddIp{ get; set; }
        public string ValidateIp{ get; set; }
        public int Category{ get; set; }
    }
}
