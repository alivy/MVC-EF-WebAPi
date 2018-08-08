using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_BrowsingTypeService : ServiceBase<Q_BrowsingType>
    {
       
    }

    public class Q_BrowsingType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public string Content{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string SendTime{ get; set; }
        public int? UserRange{ get; set; }
        public string Remarks{ get; set; }
    }
}
