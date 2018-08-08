using System;
using System.Collections.Generic;
using System.Text;
using Zephyr.Core;

namespace Zephyr.Models
{
    public class P_LoanApplyMortgageService : ServiceBase<P_LoanApplyMortgage>
    {
       
    }

    public class P_LoanApplyMortgage : ModelBase
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public int LoanApplyId{ get; set; }
        public string DrivingCard{ get; set; }
        public string PilotCard{ get; set; }
        public string HouseCard{ get; set; }
        public int MortgageType{ get; set; }
    }
}
