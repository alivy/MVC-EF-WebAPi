using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_UserSmsType : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public string Remark{ get; set; }
        public int? SortNum{ get; set; }
        public int IsDel{ get; set; }
    }
}
