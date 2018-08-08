using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class telService : ServiceBase<tel>
    {
       
    }

    public class tel : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string tel{ get; set; }
    }
}
