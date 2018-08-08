using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_OurInfluenceService : ServiceBase<Q_OurInfluence>
    {
       
    }

    public class Q_OurInfluence : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string Title{ get; set; }
        public string ImgUrl{ get; set; }
        public string LinkUrl{ get; set; }
        public int? IsWork{ get; set; }
        public int? OrderNum{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
