using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class S_InsuranceOrder_bakMapping : EntityTypeConfiguration<S_InsuranceOrder_bak>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public S_InsuranceOrder_bakMapping()
        {
            ToTable("S_InsuranceOrder_bak");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
