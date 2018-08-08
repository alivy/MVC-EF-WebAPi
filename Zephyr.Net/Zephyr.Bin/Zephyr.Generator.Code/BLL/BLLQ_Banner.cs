using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_BannerBLL : BaseBLL<Q_Banner>
    {
        public Q_BannerDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_BannerDal();
        }      
    }
}
