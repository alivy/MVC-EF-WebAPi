using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AboutSubjectRecordService : ServiceBase<Q_AboutSubjectRecord>
    {
       
    }

    public class Q_AboutSubjectRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal Amount{ get; set; }
        public int Day{ get; set; }
        public DateTime PublicTime{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectPayId{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
