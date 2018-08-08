using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class T_AnniversaryRedMoneyBLL : BaseBLL<T_AnniversaryRedMoney>
    {
        public T_AnniversaryRedMoneyDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new T_AnniversaryRedMoneyDal();
        }      
    }
}
