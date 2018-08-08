using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_CandyRainService : ServiceBase<T_CandyRain>
    {
       
    }

    public class T_CandyRain : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int TypeId{ get; set; }
        public int? RedTypeId{ get; set; }
        public int RedId{ get; set; }
        public int TotalNum{ get; set; }
        public int CurrentNum{ get; set; }
        public int IsLuckyDraw{ get; set; }
        public int IsUsed{ get; set; }
        public DateTime AddTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
    }
}
