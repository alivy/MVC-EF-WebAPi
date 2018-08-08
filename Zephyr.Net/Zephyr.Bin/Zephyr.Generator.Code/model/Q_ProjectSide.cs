using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_ProjectSideService : ServiceBase<Q_ProjectSide>
    {
       
    }

    public class Q_ProjectSide : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
