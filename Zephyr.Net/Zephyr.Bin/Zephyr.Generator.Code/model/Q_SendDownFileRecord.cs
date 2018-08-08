using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SendDownFileRecordService : ServiceBase<Q_SendDownFileRecord>
    {
       
    }

    public class Q_SendDownFileRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string returnCode{ get; set; }
        public string returnMSG{ get; set; }
        public string fileName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string MD5{ get; set; }
        public int? DownNum{ get; set; }
    }
}
