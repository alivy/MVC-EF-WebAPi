using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_UserSpeak : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpendId{ get; set; }
        public string NickName{ get; set; }
        public string HeadImg{ get; set; }
        public string Remark{ get; set; }
        public string Sex{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
