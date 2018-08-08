using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_OperationAreaService : ServiceBase<Q_OperationArea>
    {
       
    }

    public class Q_OperationArea : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int OperationId{ get; set; }
        public string AreaCode{ get; set; }
        public int PeopleCount{ get; set; }
        public decimal InvestTotal{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
