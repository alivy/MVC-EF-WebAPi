using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class Q_R_ActionInfo_UserInfoMapping : EntityTypeConfiguration<Q_R_ActionInfo_UserInfo>
    {
        /// <summary>
        /// ÐèÒªÓ³Éä×Ö¶Î
        /// </summary>
        public Q_R_ActionInfo_UserInfoMapping()
        {
            ToTable("Q_R_ActionInfo_UserInfo");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
