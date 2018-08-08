using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Q_SubJectRepaySignBLL : BaseBLL<Q_SubJectRepaySign>
    {
        public Q_SubJectRepaySignDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new Q_SubJectRepaySignDal();
        }      
    }
}
