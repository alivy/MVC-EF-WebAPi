using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class D_AreaMapping : EntityTypeConfiguration<D_Area>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public D_AreaMapping()
        {
            ToTable("D_Area");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
