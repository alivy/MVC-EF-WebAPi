using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceOrderMapping : EntityTypeConfiguration<S_InsuranceOrder>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public S_InsuranceOrderMapping()
        {
            ToTable("S_InsuranceOrder");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
