using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_JoinPositionService : ServiceBase<Q_JoinPosition>
    {
       
    }

    public class Q_JoinPosition : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string JobName{ get; set; }
        public string JobReq{ get; set; }
        public string PositionDesc{ get; set; }
        public int HiringNum{ get; set; }
        public int DeptId{ get; set; }
        public int IsDel{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
