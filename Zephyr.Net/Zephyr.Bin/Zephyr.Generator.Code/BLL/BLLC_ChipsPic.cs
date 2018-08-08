using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class C_ChipsPicBLL : BaseBLL<C_ChipsPic>
    {
        public C_ChipsPicDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new C_ChipsPicDal();
        }      
    }
}
