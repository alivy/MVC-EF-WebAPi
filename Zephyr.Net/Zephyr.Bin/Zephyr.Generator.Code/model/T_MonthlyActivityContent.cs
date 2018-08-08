using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MonthlyActivityContent : IAggregateRoot
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
