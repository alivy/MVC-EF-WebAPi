using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_User_20180612 : IAggregateRoot
    {

        [Identity]
        public int id{ get; set; }
        public string UserName{ get; set; }
        public string NickName{ get; set; }
        public string PassWord{ get; set; }
        public string PassPay{ get; set; }
        public string HeadPic{ get; set; }
        public int? Score{ get; set; }
        public int? UserType{ get; set; }
        public DateTime? LockingTime{ get; set; }
        public int? UserSate{ get; set; }
        public int? CreditLine{ get; set; }
        public int? Consultant{ get; set; }
        public int? Pid{ get; set; }
        public int? PPid{ get; set; }
        public int? Audit{ get; set; }
        public DateTime? RegTime{ get; set; }
        public DateTime? UpdateTime{ get; set; }
        public string SmsTypeString{ get; set; }
        public int? FormUid{ get; set; }
        public int? RegType{ get; set; }
        public string SignPwd{ get; set; }
        public int UserClass{ get; set; }
        public int FailNum{ get; set; }
    }
}
