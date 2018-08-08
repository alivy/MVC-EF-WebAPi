using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class F_Contract : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int ReUid{ get; set; }
        public string LoanNumber{ get; set; }
        public int SubjectPayId{ get; set; }
        public string InvestOrder{ get; set; }
        public string TemplateNo{ get; set; }
        public string ContractNo{ get; set; }
        public string DownloadUrl{ get; set; }
        public string ViewpdfUrl{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public int SubjectBidId{ get; set; }
    }
}
