using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_SubjectMoneyBack : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int BackType{ get; set; }
        public int SubjectPayId{ get; set; }
        public int SubjectBidId{ get; set; }
        public int UserId{ get; set; }
        public decimal InvestNum{ get; set; }
        public decimal BackNum{ get; set; }
        public DateTime InvestTime{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? InvestDay{ get; set; }
        public string OrderNum{ get; set; }
        public int? BackStatus{ get; set; }
        public int? Q_RewardRecordId{ get; set; }
    }
}
