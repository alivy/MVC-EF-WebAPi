using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceQuoteInfo_bakMapping : EntityTypeConfiguration<S_InsuranceQuoteInfo_bak>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public S_InsuranceQuoteInfo_bakMapping()
        {
            ToTable("S_InsuranceQuoteInfo_bak");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
