using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class S_FlowProductService : ServiceBase<S_FlowProduct>
    {
       
    }

    public class S_FlowProduct : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ProductName{ get; set; }
        public string HProductId{ get; set; }
        public int? GetNum{ get; set; }
        public string SortNum{ get; set; }
        public string CarrierType{ get; set; }
        public string Remark{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
