using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_LoanApplyPersonalService : ServiceBase<P_LoanApplyPersonal>
    {
       
    }

    public class P_LoanApplyPersonal : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanApplyId{ get; set; }
        public string CompanyName{ get; set; }
        public string CompanyAddress{ get; set; }
        public int Profession{ get; set; }
        public string CardPhoto{ get; set; }
    }
}
