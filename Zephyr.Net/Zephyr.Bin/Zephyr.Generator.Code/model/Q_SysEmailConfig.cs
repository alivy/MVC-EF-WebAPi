using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SysEmailConfig : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Smtp{ get; set; }
        public string Port{ get; set; }
        public string Email{ get; set; }
        public string PassWord{ get; set; }
        public string FromName{ get; set; }
    }
}
