using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_DiamondMemberRuleMapping : EntityTypeConfiguration<T_DiamondMemberRule>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_DiamondMemberRuleMapping()
        {
            ToTable("T_DiamondMemberRule");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
