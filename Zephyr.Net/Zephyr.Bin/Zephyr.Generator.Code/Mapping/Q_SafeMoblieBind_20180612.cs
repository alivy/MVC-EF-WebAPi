using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_SafeMoblieBind_20180612Mapping : EntityTypeConfiguration<Q_SafeMoblieBind_20180612>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_SafeMoblieBind_20180612Mapping()
        {
            ToTable("Q_SafeMoblieBind_20180612");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
