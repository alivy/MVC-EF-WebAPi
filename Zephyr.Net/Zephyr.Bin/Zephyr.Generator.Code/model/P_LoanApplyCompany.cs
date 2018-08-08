using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_LoanApplyCompanyService : ServiceBase<P_LoanApplyCompany>
    {
       
    }

    public class P_LoanApplyCompany : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanApplyId{ get; set; }
        public string CompanyCard{ get; set; }
        public string CashFlowFile{ get; set; }
        public string Finances{ get; set; }
    }
}
