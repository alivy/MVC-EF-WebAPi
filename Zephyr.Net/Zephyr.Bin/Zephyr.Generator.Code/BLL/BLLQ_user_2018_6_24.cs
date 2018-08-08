using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_user_2018_6_24BLL : BaseBLL<Q_user_2018_6_24>
    {
        public Q_user_2018_6_24Dal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_user_2018_6_24Dal();
        }      
    }
}
