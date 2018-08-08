using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class T_ManmonFinancialBLL : BaseBLL<T_ManmonFinancial>
    {
        public T_ManmonFinancialDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new T_ManmonFinancialDal();
        }      
    }
}
