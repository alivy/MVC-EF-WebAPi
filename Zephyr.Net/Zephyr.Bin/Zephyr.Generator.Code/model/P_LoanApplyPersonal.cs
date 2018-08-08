using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_LoanApplyPersonal : IAggregateRoot
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
