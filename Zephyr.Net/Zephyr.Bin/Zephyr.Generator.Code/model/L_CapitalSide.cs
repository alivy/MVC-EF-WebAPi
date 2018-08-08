using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_CapitalSideService : ServiceBase<L_CapitalSide>
    {
       
    }

    public class L_CapitalSide : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ProjectName{ get; set; }
        public string CapitalType{ get; set; }
        public string InvestRange{ get; set; }
        public string InvestDay{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? EditTime{ get; set; }
        public int? VisitCount{ get; set; }
        public string ContentDescription{ get; set; }
    }
}
