using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class T_CandyRainTypeService : ServiceBase<T_CandyRainType>
    {
       
    }

    public class T_CandyRainType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string TypeName{ get; set; }
        public int Sort{ get; set; }
        public DateTime AddTime{ get; set; }
    }
}
