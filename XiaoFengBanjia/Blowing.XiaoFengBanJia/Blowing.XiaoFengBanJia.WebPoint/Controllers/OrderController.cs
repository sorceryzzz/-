using Blowing.XiaoFengBanJia.Bll.Order;
using Blowing.XiaoFengBanJia.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blowing.XiaoFengBanJia.WebPoint.Controllers
{
    public class OrderController : Controller
    {
        OrderInfoBll orInfoBll = new OrderInfoBll();


        /// <summary>
        /// 生成订单
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GenerOrder()
        {
            return View();
        }
       /// <summary>
       /// 生成订单POST
       /// </summary>
       /// <returns>-1 参数错误</returns>
        [HttpPost]
        public ContentResult GenerOrderPost(decimal totalMoney,int orBuisnessID)
        {
            if (totalMoney <= 0 && orBuisnessID <= 0)
            {
                return Content("-1");
            }
            OrderInfo orInfo = new OrderInfo();

            orInfo.TotalMoney = totalMoney;
            orInfo.OrderBuinessID = orBuisnessID;
            bool resultBool = orInfoBll.GenerOrder(orInfo);
            return Content(resultBool?"1":"0");
        }
    }
}