using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_BankBind_20180605BLL : BaseBLL<Q_BankBind_20180605>
    {
        public Q_BankBind_20180605Dal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_BankBind_20180605Dal();
        }      
    }
}
