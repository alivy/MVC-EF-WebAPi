using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class D_AreaService : ServiceBase<D_Area>
    {
       
    }

    public class D_Area : ModelBase
    {

        public string areaCode{ get; set; }
        public int? areaLv{ get; set; }
        public string areaName{ get; set; }
        public string parentCode{ get; set; }
    }
}
