using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubjectBidProgressRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectBidId{ get; set; }
        public string InvestOrder{ get; set; }
        public decimal InvestNum{ get; set; }
        public int InvestState{ get; set; }
        public DateTime AddTime{ get; set; }
        public int RedId{ get; set; }
        public int LvBondId{ get; set; }
        public int InvestType{ get; set; }
        public string SerialNumber{ get; set; }
    }
}
