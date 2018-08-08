using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_SpringFestival : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int IsGet{ get; set; }
        public int UserType{ get; set; }
        public int OpenCount{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
