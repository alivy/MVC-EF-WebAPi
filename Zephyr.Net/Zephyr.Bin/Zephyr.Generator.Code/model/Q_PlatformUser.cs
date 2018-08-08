using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_PlatformUserService : ServiceBase<Q_PlatformUser>
    {
       
    }

    public class Q_PlatformUser : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? FormId{ get; set; }
        public int? UserId{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? Type{ get; set; }
    }
}
