using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_PlatformService : ServiceBase<Q_Platform>
    {
       
    }

    public class Q_Platform : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string FormName{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string LinkUrl{ get; set; }
        public int? FormType{ get; set; }
    }
}
