using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_SubjectMoneyBackTypeMapping : EntityTypeConfiguration<T_SubjectMoneyBackType>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_SubjectMoneyBackTypeMapping()
        {
            ToTable("T_SubjectMoneyBackType");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
