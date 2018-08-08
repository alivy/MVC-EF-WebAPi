using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class T_DiamondMemberConfigBLL : BaseBLL<T_DiamondMemberConfig>
    {
        public T_DiamondMemberConfigDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new T_DiamondMemberConfigDal();
        }      
    }
}
