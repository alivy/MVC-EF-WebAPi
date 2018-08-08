using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MoneyRain : IAggregateRoot
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
