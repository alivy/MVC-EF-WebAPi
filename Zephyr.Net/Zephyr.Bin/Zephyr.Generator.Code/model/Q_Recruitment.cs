using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RecruitmentService : ServiceBase<Q_Recruitment>
    {
       
    }

    public class Q_Recruitment : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string FullName{ get; set; }
        public string Mobile{ get; set; }
        public string Email{ get; set; }
        public string Position{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
