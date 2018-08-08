
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Zephyr.Core;
using Zephyr.Models;

namespace Zephyr.Areas.Sys.Controllers
{
    public class OrganizeController : Controller
    {
        public ActionResult Index()
        {
            var model = new
            {
                urls = new {
                    query = "/api/Sys/Organize",
                    remove = "/api/Sys/Organize/",
                    billno = "/api/Sys/Organize/getnewbillno",
                    audit = "/api/Sys/Organize/audit/",
                    edit = "/Sys/Organize/edit/"
                },
                resx = new {
                    detailTitle = "单据明细",
                    noneSelect = "请先选择一条单据！",
                    deleteConfirm = "确定要删除选中的单据吗？",
                    deleteSuccess = "删除成功！",
                    auditSuccess = "单据已审核！"
                },
                dataSource = new{
                    //dsPurpose = new sys_codeService().GetValueTextListByType("Purpose")
                },
                form = new{
                    OrganizeCode = "" ,
                    ParentCode = "" ,
                    OrganizeName = "" ,
                    Description = "" ,
                    CreatePerson = "" ,
                    UpdatePerson = "" ,
                    UpdateDate = "" 
                },
                idField="OrganizeCode"
            };

            return View(model);
        }
    }

    public class OrganizeApiController : ApiController
    {
        

        public string GetNewBillNo()
        {
            return new sys_organizeService.GetNewKey("OrganizeCode", "dateplus");
        }

        public dynamic Get(RequestWrapper query)
        {
            query.LoadSettingXmlString(@"
<settings defaultOrderBy='OrganizeCode'>
    <select>*</select>
    <from>sys_organize</from>
    <where defaultForAll='true' defaultCp='equal' defaultIgnoreEmpty='true' >
        <field name='OrganizeCode'		cp='equal'></field>   
        <field name='ParentCode'		cp='equal'></field>   
        <field name='OrganizeName'		cp='equal'></field>   
        <field name='Description'		cp='equal'></field>   
        <field name='CreatePerson'		cp='equal'></field>   
        <field name='UpdatePerson'		cp='equal'></field>   
        <field name='UpdateDate'		cp='equal'></field>   
    </where>
</settings>");
            var service = new sys_organizeService();
            var pQuery = query.ToParamQuery();
            var result = service.GetDynamicListWithPaging(pQuery);
            return result;
        }
    }
}
