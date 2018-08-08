using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class L_LoanUserInfoService : ServiceBase<L_LoanUserInfo>
    {
       
    }

    public class L_LoanUserInfo : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int Education{ get; set; }
        public int MaritalStatus{ get; set; }
        public string Email{ get; set; }
        public string ComName{ get; set; }
        public string ComTel{ get; set; }
        public string Department{ get; set; }
        public string Post{ get; set; }
        public int HasHouse{ get; set; }
        public int HasCard{ get; set; }
        public DateTime AddTime{ get; set; }
        public int State{ get; set; }
        public string AuditOpinion{ get; set; }
        public decimal MonthIncome{ get; set; }
    }
}
