using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceRelation_bak : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OrderNumber{ get; set; }
        public int? RelationType{ get; set; }
        public string IdType{ get; set; }
        public string TrueName{ get; set; }
        public string IdNo{ get; set; }
        public string Phone{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string Email{ get; set; }
    }
}
