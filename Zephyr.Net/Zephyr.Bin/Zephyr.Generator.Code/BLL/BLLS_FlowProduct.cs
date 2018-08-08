using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_FlowProductBLL : BaseBLL<S_FlowProduct>
    {
        public S_FlowProductDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_FlowProductDal();
        }      
    }
}
