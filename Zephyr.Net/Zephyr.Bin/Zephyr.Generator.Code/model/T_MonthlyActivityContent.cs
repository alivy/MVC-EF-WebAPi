using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MonthlyActivityContentService : ServiceBase<T_MonthlyActivityContent>
    {
       
    }

    public class T_MonthlyActivityContent : ModelBase
    {

        [Identity]
        public int id{ get; set; }
        public int? MonthlyID{ get; set; }
        public decimal? FInvestNum{ get; set; }
        public decimal? InvestNum2{ get; set; }
        public decimal? InvestNum3{ get; set; }
        public decimal? InvestNum4{ get; set; }
        public decimal RedBagNum{ get; set; }
        public decimal? RedBagNum2{ get; set; }
        public decimal? RedBagNum3{ get; set; }
        public decimal? RedBagNum4{ get; set; }
        public decimal? InNum{ get; set; }
        public decimal? InNum2{ get; set; }
        public decimal? InNum3{ get; set; }
        public decimal? InNum4{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? State{ get; set; }
    }
}
