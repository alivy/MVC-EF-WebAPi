using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class D_IdCardTypeMapping : EntityTypeConfiguration<D_IdCardType>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public D_IdCardTypeMapping()
        {
            ToTable("D_IdCardType");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
