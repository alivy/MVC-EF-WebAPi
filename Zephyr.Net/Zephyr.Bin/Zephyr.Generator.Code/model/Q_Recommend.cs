using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RecommendService : ServiceBase<Q_Recommend>
    {
       
    }

    public class Q_Recommend : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal Profit{ get; set; }
        public int Pid{ get; set; }
        public decimal PNum{ get; set; }
        public int PPid{ get; set; }
        public decimal PPNum{ get; set; }
        public DateTime AddTime{ get; set; }
        public int SubjectPayId{ get; set; }
        public int? Wpid{ get; set; }
        public string Other{ get; set; }
        public string Desc{ get; set; }
        public int? State{ get; set; }
        public int? SubjectBidId{ get; set; }
    }
}
