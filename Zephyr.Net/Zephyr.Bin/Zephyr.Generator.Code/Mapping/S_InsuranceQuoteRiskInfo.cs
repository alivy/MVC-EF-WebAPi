using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceQuoteRiskInfoMapping : EntityTypeConfiguration<S_InsuranceQuoteRiskInfo>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public S_InsuranceQuoteRiskInfoMapping()
        {
            ToTable("S_InsuranceQuoteRiskInfo");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
