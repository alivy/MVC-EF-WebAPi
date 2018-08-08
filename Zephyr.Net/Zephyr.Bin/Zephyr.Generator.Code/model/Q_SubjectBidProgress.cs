using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SubjectBidProgressService : ServiceBase<Q_SubjectBidProgress>
    {
       
    }

    public class Q_SubjectBidProgress : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public decimal Amount{ get; set; }
        public decimal SurplusNum{ get; set; }
        public decimal? LockNum{ get; set; }
        public int? State{ get; set; }
    }
}
