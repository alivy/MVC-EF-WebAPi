using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_UserAnnualDataService : ServiceBase<Q_UserAnnualData>
    {
       
    }

    public class Q_UserAnnualData : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int Year{ get; set; }
        public decimal TotalInvest{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime UpdateTime{ get; set; }
    }
}
