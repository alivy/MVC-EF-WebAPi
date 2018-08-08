using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class C_ChipsAttronBLL : BaseBLL<C_ChipsAttron>
    {
        public C_ChipsAttronDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new C_ChipsAttronDal();
        }      
    }
}
