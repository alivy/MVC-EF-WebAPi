using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_ScoreProduct : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string ProductName{ get; set; }
        public string Introduce{ get; set; }
        public string ImgUrl{ get; set; }
        public string DetailImgUrl{ get; set; }
        public int? TotalCount{ get; set; }
        public int? ScorePrice{ get; set; }
        public int? State{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? ProductType{ get; set; }
        public string Remark{ get; set; }
        public decimal? CostPrice{ get; set; }
        public int? GetNum{ get; set; }
        public string CarrierType{ get; set; }
        public string HProductId{ get; set; }
    }
}
