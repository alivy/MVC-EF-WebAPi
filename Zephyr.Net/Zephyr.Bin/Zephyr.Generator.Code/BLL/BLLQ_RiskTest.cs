using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_RiskTestBLL : BaseBLL<Q_RiskTest>
    {
        public Q_RiskTestDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_RiskTestDal();
        }      
    }
}
