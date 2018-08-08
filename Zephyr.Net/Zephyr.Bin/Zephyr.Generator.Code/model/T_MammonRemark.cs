using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_MammonRemarkService : ServiceBase<T_MammonRemark>
    {
       
    }

    public class T_MammonRemark : ModelBase
    {

        [PrimaryKey]
        public int Id{ get; set; }
        public string Character{ get; set; }
        public string Mammon{ get; set; }
        public string MammonRemark{ get; set; }
        public string MammonImg{ get; set; }
        public string MammonDescribe{ get; set; }
    }
}
