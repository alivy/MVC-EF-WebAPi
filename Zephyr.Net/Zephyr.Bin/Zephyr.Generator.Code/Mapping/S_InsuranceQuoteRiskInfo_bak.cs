using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceQuoteRiskInfo_bakMapping : EntityTypeConfiguration<S_InsuranceQuoteRiskInfo_bak>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public S_InsuranceQuoteRiskInfo_bakMapping()
        {
            ToTable("S_InsuranceQuoteRiskInfo_bak");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
