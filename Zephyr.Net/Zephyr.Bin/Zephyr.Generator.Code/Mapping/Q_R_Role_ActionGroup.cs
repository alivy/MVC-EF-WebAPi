using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_Role_ActionGroupMapping : EntityTypeConfiguration<Q_R_Role_ActionGroup>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_R_Role_ActionGroupMapping()
        {
            ToTable("Q_R_Role_ActionGroup");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
