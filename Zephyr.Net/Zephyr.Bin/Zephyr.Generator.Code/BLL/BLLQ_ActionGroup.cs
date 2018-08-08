using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_ActionGroupBLL : BaseBLL<Q_ActionGroup>
    {
        public Q_ActionGroupDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_ActionGroupDal();
        }      
    }
}
