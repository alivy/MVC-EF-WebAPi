using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_R_ActionInfo_UserInfoBLL : BaseBLL<Q_R_ActionInfo_UserInfo>
    {
        public Q_R_ActionInfo_UserInfoDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_R_ActionInfo_UserInfoDal();
        }      
    }
}
