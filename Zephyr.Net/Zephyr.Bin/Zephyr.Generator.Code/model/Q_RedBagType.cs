using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_RedBagTypeService : ServiceBase<Q_RedBagType>
    {
       
    }

    public class Q_RedBagType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Title{ get; set; }
        public int Type{ get; set; }
        public string Action{ get; set; }
        public int? ActionType{ get; set; }
        public DateTime AddTime{ get; set; }
        public string UseRule{ get; set; }
        public string ActionDay{ get; set; }
        public int? MinNum{ get; set; }
    }
}
