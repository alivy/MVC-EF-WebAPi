using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class F_ContractFilingBLL : BaseBLL<F_ContractFiling>
    {
        public F_ContractFilingDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new F_ContractFilingDal();
        }      
    }
}
