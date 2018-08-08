using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_MailRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int UId{ get; set; }
        public int Category{ get; set; }
        public string Content{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Ip{ get; set; }
        public string Email{ get; set; }
    }
}
