using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ActivityOperationMapping : EntityTypeConfiguration<T_ActivityOperation>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_ActivityOperationMapping()
        {
            ToTable("T_ActivityOperation");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
