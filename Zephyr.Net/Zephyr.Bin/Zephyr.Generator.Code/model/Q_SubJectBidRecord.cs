using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SubJectBidRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int? uid{ get; set; }
        public int? SubjectPayId{ get; set; }
        public string LoanNumber{ get; set; }
        public string ContractNumber{ get; set; }
        public string InvestOrder{ get; set; }
        public decimal? InvestNum{ get; set; }
        public int? InvestType{ get; set; }
        public int? InvestState{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string OrderNum{ get; set; }
        public string AuthCode{ get; set; }
    }
}
