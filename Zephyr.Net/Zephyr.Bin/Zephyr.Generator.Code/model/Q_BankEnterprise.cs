using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_BankEnterprise : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Cert_No{ get; set; }
        public string Name{ get; set; }
        public string Mobile{ get; set; }
        public string Bind_Card{ get; set; }
        public string Card_No{ get; set; }
        public string Customer_No{ get; set; }
        public string Serial_No{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
