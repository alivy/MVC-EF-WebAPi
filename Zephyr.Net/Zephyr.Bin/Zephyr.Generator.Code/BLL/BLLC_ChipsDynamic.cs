using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class C_ChipsDynamicBLL : BaseBLL<C_ChipsDynamic>
    {
        public C_ChipsDynamicDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new C_ChipsDynamicDal();
        }      
    }
}
