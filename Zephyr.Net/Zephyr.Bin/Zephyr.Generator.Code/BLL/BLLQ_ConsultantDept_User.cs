using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_ConsultantDept_UserBLL : BaseBLL<Q_ConsultantDept_User>
    {
        public Q_ConsultantDept_UserDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_ConsultantDept_UserDal();
        }      
    }
}
