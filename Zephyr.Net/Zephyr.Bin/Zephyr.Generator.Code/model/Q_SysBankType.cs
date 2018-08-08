using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class Q_SysBankTypeService : ServiceBase<Q_SysBankType>
    {
       
    }

    public class Q_SysBankType : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int id{ get; set; }
        public string Name{ get; set; }
        public DateTime AddTime{ get; set; }
        public int? Sort{ get; set; }
        public string ImgSrc{ get; set; }
        public string CardNameEn{ get; set; }
    }
}
