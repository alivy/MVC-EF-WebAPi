using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_UserSeedRain : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? SeedId{ get; set; }
        public string OpenId{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
