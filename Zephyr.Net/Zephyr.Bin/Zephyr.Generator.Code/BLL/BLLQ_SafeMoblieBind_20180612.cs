using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_SafeMoblieBind_20180612BLL : BaseBLL<Q_SafeMoblieBind_20180612>
    {
        public Q_SafeMoblieBind_20180612Dal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_SafeMoblieBind_20180612Dal();
        }      
    }
}
