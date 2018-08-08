using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_AdvertClassService : ServiceBase<Q_AdvertClass>
    {
       
    }

    public class Q_AdvertClass : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public string ClassName{ get; set; }
        public int? UserId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public string UserName{ get; set; }
    }
}
