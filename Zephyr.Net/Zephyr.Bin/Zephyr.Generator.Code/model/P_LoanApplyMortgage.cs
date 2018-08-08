using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_LoanApplyMortgage : IAggregateRoot
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
