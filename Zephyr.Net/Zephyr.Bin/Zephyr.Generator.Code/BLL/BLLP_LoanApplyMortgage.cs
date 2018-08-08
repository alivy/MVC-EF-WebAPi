using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class P_LoanApplyMortgageBLL : BaseBLL<P_LoanApplyMortgage>
    {
        public P_LoanApplyMortgageDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new P_LoanApplyMortgageDal();
        }      
    }
}
