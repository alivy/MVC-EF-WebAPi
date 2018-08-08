using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_WarrantorLV : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? Uid{ get; set; }
        public int? OverdueDay{ get; set; }
        public decimal? OverdueLv{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
