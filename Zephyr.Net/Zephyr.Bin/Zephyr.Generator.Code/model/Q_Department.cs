using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_DepartmentService : ServiceBase<Q_Department>
    {
       
    }

    public class Q_Department : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string DeptName{ get; set; }
        public int DelFlag{ get; set; }
        public DateTime AddTime{ get; set; }
        public string Remark{ get; set; }
    }
}
