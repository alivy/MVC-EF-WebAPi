using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ConsultantDeptService : ServiceBase<Q_ConsultantDept>
    {
       
    }

    public class Q_ConsultantDept : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string DeptName{ get; set; }
        public int? Sort{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
