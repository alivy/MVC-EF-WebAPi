using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ComPanyInfo : IAggregateRoot
    {

        [PrimaryKey]
        public int id{ get; set; }
        public string ContactPerson{ get; set; }
        public string ContactPhone{ get; set; }
        public string LicenseNumber{ get; set; }
        public string RegistrationNumber{ get; set; }
        public string Desc{ get; set; }
        public int? State{ get; set; }
        public int? OperatorId{ get; set; }
        public DateTime? OperatorTime{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
