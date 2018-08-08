using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_SafeOrderInfoBLL : BaseBLL<Q_SafeOrderInfo>
    {
        public Q_SafeOrderInfoDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_SafeOrderInfoDal();
        }      
    }
}
