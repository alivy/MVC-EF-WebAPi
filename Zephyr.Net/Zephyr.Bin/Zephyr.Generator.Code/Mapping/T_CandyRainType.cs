using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_CandyRainTypeMapping : EntityTypeConfiguration<T_CandyRainType>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_CandyRainTypeMapping()
        {
            ToTable("T_CandyRainType");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
