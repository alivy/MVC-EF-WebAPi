using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SysBankType : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? Sort{ get; set; }
        public string ImgSrc{ get; set; }
        public string CardNameEn{ get; set; }
    }
}
