using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_SafeOrderDetail_bakBLL : BaseBLL<Q_SafeOrderDetail_bak>
    {
        public Q_SafeOrderDetail_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_SafeOrderDetail_bakDal();
        }      
    }
}
