using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ConsultantDept_UserService : ServiceBase<Q_ConsultantDept_User>
    {
       
    }

    public class Q_ConsultantDept_User : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int DeptId{ get; set; }
        public int Consultant{ get; set; }
        public int IsDel{ get; set; }
        public int IsMana{ get; set; }
        public int Sort{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
