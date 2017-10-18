using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WeCan.BusinessLogic;
using WeCan.Models;

namespace WeWap.Controllers
{
    /// <summary>
    /// 常规移动端资讯类项目
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// 默认页
        /// </summary>
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 清单
        /// </summary>
        public ActionResult List(Pagination pn)
        {
            var biz = new ItemBiz();
            var list = biz.GetItemList(pn);
            return View(list);
        }
        /// <summary>
        /// 详情
        /// </summary>
        public ActionResult Details(ItemSummaryM item)
        {
            var biz = new ItemBiz();
            item = biz.GetItemById(1,1,1,"");
            return View();
        }
        /// <summary>
        /// 分部视图
        /// </summary>
        /// <param name="id">静态视图的名称</param>
        public ActionResult PartView(string id)
        {
            return PartialView(id);
        }
    }
}