using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class T_JXWithdrawalBLL : BaseBLL<T_JXWithdrawal>
    {
        public T_JXWithdrawalDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new T_JXWithdrawalDal();
        }      
    }
}
