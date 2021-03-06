using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_U_WeiXin : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string OpenId{ get; set; }
        public string AppOpenId{ get; set; }
        public string NickName{ get; set; }
        public int Sex{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public string Country{ get; set; }
        public string Headimgurl{ get; set; }
        public string Privilege{ get; set; }
        public string UnionId{ get; set; }
        public DateTime AddTime{ get; set; }
        public int IsDel{ get; set; }
    }
}
