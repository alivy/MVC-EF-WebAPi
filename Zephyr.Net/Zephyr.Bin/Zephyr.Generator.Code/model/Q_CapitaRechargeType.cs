using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_CapitaRechargeTypeService : ServiceBase<Q_CapitaRechargeType>
    {
       
    }

    public class Q_CapitaRechargeType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public DateTime AddTime{ get; set; }
        public int Sorts{ get; set; }
    }
}
