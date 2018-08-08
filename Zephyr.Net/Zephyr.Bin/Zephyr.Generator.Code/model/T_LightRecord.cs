using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_LightRecordService : ServiceBase<T_LightRecord>
    {
       
    }

    public class T_LightRecord : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int PidCount{ get; set; }
        public decimal TotalInvestNum{ get; set; }
        public decimal TotalInvestNum30{ get; set; }
        public decimal TotalInvestNum90{ get; set; }
        public decimal TotalInvestNum180{ get; set; }
        public int LigntCount{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public int? IsPid{ get; set; }
        public int? PidState{ get; set; }
        public int? InvestState{ get; set; }
        public int? InvestState2{ get; set; }
        public int? InvestState3{ get; set; }
        public int? TotalState{ get; set; }
    }
}
