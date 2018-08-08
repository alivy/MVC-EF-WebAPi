using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class L_LoanUserInfo : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int Education{ get; set; }
        public int MaritalStatus{ get; set; }
        public string Email{ get; set; }
        public string ComName{ get; set; }
        public string ComTel{ get; set; }
        public string Department{ get; set; }
        public string Post{ get; set; }
        public int HasHouse{ get; set; }
        public int HasCard{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public string AuditOpinion{ get; set; }
        public decimal MonthIncome{ get; set; }
    }
}
