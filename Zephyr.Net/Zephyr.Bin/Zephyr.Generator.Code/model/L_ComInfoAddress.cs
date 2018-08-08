using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_ComInfoAddressService : ServiceBase<L_ComInfoAddress>
    {
       
    }

    public class L_ComInfoAddress : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int LoanComInfoId{ get; set; }
        public int AddressId{ get; set; }
        public int TypeId{ get; set; }
    }
}
