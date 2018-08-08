using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_UserInfoLogin : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int Type{ get; set; }
        public string IP{ get; set; }
        public int State{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Browser{ get; set; }
        public int? LoginHash{ get; set; }
    }
}
