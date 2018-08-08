using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class D_IdCardTypeService : ServiceBase<D_IdCardType>
    {
       
    }

    public class D_IdCardType : ModelBase
    {

        public string TypeId{ get; set; }
        public string TypeName{ get; set; }
    }
}
