using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_UserSeedRainService : ServiceBase<T_UserSeedRain>
    {
       
    }

    public class T_UserSeedRain : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int? SeedId{ get; set; }
        public string OpenId{ get; set; }
        public DateTime? AddTime{ get; set; }
    }
}
