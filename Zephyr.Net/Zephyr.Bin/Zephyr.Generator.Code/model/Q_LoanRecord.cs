using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_LoanRecordService : ServiceBase<Q_LoanRecord>
    {
       
    }

    public class Q_LoanRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public decimal Amount{ get; set; }
        public int Day{ get; set; }
        public string Tel{ get; set; }
        public string Description{ get; set; }
        public int Uid{ get; set; }
        public string LoanNumber{ get; set; }
        public int State{ get; set; }
        public DateTime Addtime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
