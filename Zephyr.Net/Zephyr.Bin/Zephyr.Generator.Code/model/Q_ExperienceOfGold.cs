using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ExperienceOfGold : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? Type{ get; set; }
        public decimal? Amount{ get; set; }
        public string Desc{ get; set; }
        public int? Uid{ get; set; }
        public int? State{ get; set; }
        public DateTime BeginTime{ get; set; }
        public DateTime EndTime{ get; set; }
    }
}
