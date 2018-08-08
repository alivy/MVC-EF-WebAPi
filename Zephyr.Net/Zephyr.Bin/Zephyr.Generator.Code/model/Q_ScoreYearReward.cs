using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ScoreYearRewardService : ServiceBase<Q_ScoreYearReward>
    {
       
    }

    public class Q_ScoreYearReward : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public int BackType{ get; set; }
        public int UserId{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal InvestNum3{ get; set; }
        public decimal InvestNum6{ get; set; }
        public decimal BackNum{ get; set; }
        public int IsGet{ get; set; }
        public DateTime AddTime{ get; set; }
        public decimal InvestNum12{ get; set; }
    }
}
