using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class P_CompanyAuth : IAggregateRoot
    {

        [Identity]
        [PrimaryKey]
        public int Id{ get; set; }
        public int Uid{ get; set; }
        public string CompanyName{ get; set; }
        public string CompanyCardNum{ get; set; }
        public string CompanyPhone{ get; set; }
        public int CompanyNum{ get; set; }
        public string CompanyAddress{ get; set; }
        public string LegalPerson{ get; set; }
        public string CardNum{ get; set; }
        public string BankName{ get; set; }
        public string BankNum{ get; set; }
        public int ProvinceId{ get; set; }
        public int CityId{ get; set; }
        public string BankBranchName{ get; set; }
        public string CompanyCard{ get; set; }
        public string OrganizationCodeCard{ get; set; }
        public string TaxCard{ get; set; }
        public string BankCard{ get; set; }
        public string OfficePhoto1{ get; set; }
        public string OfficePhoto2{ get; set; }
        public string OfficePhoto3{ get; set; }
        public string LegalPersonCard{ get; set; }
        public DateTime? AddTime{ get; set; }
        public int? AuditUid{ get; set; }
        public string AuditOpinion{ get; set; }
        public DateTime? AuditTime{ get; set; }
        public int? State{ get; set; }
    }
}
