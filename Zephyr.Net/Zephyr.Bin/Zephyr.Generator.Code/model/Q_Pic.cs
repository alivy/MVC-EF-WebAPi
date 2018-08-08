using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_Pic : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string PicUrl{ get; set; }
        public int Type{ get; set; }
        public string Title{ get; set; }
        public int ProType{ get; set; }
        public int SubjectPayId{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
