using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_NationalUserOperationMapping : EntityTypeConfiguration<T_NationalUserOperation>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_NationalUserOperationMapping()
        {
            ToTable("T_NationalUserOperation");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
