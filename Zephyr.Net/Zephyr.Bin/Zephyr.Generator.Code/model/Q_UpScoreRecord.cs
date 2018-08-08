using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UpScoreRecordService : ServiceBase<Q_UpScoreRecord>
    {
       
    }

    public class Q_UpScoreRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string Remark{ get; set; }
        public DateTime SignTime{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
