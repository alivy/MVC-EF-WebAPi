using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_LoanPersonalContactsService : ServiceBase<L_LoanPersonalContacts>
    {
       
    }

    public class L_LoanPersonalContacts : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanUserInfoId{ get; set; }
        public string ContactsName{ get; set; }
        public string ContactsRelation{ get; set; }
        public string ContactsPhone{ get; set; }
        public DateTime AddTime{ get; set; }
        public int IsDel{ get; set; }
    }
}
