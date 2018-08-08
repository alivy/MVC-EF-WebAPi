using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_UserSeeds : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string OpenId{ get; set; }
        public string NickName{ get; set; }
        public string HeadImg{ get; set; }
        public string Sex{ get; set; }
        public string Country{ get; set; }
        public string Province{ get; set; }
        public string City{ get; set; }
        public string Privilege{ get; set; }
        public string UnionId{ get; set; }
        public int? IsDel{ get; set; }
        public int? IsGet{ get; set; }
        public int? GetUserId{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
