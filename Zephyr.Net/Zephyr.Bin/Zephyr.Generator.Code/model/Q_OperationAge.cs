using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_OperationAgeService : ServiceBase<Q_OperationAge>
    {
       
    }

    public class Q_OperationAge : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int OperationId{ get; set; }
        public int Age{ get; set; }
        public int PeopleCount{ get; set; }
        public decimal InvestTotal{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
