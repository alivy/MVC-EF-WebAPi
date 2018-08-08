using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BankOperateTypeService : ServiceBase<Q_BankOperateType>
    {
       
    }

    public class Q_BankOperateType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string OperateName{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
