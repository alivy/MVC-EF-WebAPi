using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_SubjectMoneyBackMapping : EntityTypeConfiguration<T_SubjectMoneyBack>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_SubjectMoneyBackMapping()
        {
            ToTable("T_SubjectMoneyBack");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
