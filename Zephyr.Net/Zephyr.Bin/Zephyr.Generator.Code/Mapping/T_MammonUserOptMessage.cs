using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_MammonUserOptMessageMapping : EntityTypeConfiguration<T_MammonUserOptMessage>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_MammonUserOptMessageMapping()
        {
            ToTable("T_MammonUserOptMessage");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
