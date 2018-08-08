using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_U_WeiXinBLL : BaseBLL<Q_U_WeiXin>
    {
        public Q_U_WeiXinDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_U_WeiXinDal();
        }      
    }
}
