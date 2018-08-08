using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ScoreYearReward : IAggregateRoot
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
