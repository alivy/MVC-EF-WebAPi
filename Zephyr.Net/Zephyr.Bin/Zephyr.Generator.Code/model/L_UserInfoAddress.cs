using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_UserInfoAddressService : ServiceBase<L_UserInfoAddress>
    {
       
    }

    public class L_UserInfoAddress : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public int AddressId{ get; set; }
        public int TypeId{ get; set; }
    }
}
