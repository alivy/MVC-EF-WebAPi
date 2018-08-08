using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_R_UserInfo_DeptBLL : BaseBLL<Q_R_UserInfo_Dept>
    {
        public Q_R_UserInfo_DeptDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_R_UserInfo_DeptDal();
        }      
    }
}
