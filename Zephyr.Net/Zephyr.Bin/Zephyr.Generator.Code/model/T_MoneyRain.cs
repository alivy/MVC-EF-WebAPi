using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MoneyRainService : ServiceBase<T_MoneyRain>
    {
       
    }

    public class T_MoneyRain : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int SubjectId{ get; set; }
        public string LoanNumber{ get; set; }
        public decimal InvestNum{ get; set; }
        public DateTime BidAddTime{ get; set; }
        public int LuckDrawNum{ get; set; }
        public int Uid{ get; set; }
    }
}
