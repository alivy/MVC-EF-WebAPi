using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_RoleMapping : EntityTypeConfiguration<Q_Role>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_RoleMapping()
        {
            ToTable("Q_Role");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
