using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_SpringFestivalService : ServiceBase<T_SpringFestival>
    {
       
    }

    public class T_SpringFestival : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public int Uid{ get; set; }
        public int IsGet{ get; set; }
        public int UserType{ get; set; }
        public int OpenCount{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
