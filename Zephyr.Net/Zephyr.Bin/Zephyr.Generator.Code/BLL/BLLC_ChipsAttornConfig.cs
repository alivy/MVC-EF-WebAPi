using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class C_ChipsAttornConfigBLL : BaseBLL<C_ChipsAttornConfig>
    {
        public C_ChipsAttornConfigDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new C_ChipsAttornConfigDal();
        }      
    }
}
