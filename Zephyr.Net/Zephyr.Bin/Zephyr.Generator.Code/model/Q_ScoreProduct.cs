using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ScoreProductService : ServiceBase<Q_ScoreProduct>
    {
       
    }

    public class Q_ScoreProduct : ModelBase
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
