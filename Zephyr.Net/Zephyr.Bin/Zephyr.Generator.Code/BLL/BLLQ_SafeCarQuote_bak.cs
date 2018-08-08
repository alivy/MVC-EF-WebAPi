using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_SafeCarQuote_bakBLL : BaseBLL<Q_SafeCarQuote_bak>
    {
        public Q_SafeCarQuote_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_SafeCarQuote_bakDal();
        }      
    }
}
