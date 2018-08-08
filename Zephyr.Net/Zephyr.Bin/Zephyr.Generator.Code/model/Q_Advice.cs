using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AdviceService : ServiceBase<Q_Advice>
    {
       
    }

    public class Q_Advice : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public string Desc{ get; set; }
        public string Tel{ get; set; }
        public int? State{ get; set; }
        public int? Uid{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
