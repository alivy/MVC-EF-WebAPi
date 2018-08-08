using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_FlowRegister_bakBLL : BaseBLL<S_FlowRegister_bak>
    {
        public S_FlowRegister_bakDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_FlowRegister_bakDal();
        }      
    }
}
