using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_PlatformBLL : BaseBLL<Q_Platform>
    {
        public Q_PlatformDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_PlatformDal();
        }      
    }
}
