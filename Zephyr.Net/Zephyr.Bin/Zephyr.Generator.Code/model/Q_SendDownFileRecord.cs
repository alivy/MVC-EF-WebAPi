using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SendDownFileRecord : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string returnCode{ get; set; }
        public string returnMSG{ get; set; }
        public string fileName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string MD5{ get; set; }
        public int? DownNum{ get; set; }
    }
}
