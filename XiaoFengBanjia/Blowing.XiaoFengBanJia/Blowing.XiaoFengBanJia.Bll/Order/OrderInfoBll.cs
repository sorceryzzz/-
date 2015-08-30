using Blowing.XiaoFengBanJia.Dal.order;
using Blowing.XiaoFengBanJia.Model.Order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blowing.XiaoFengBanJia.Bll.Order
{
   public  class OrderInfoBll
   {
       OrderInfoDal orInfoDal = new OrderInfoDal();
       object obj = new object();

       #region - method -
       /// <summary>
       /// 生成订单
       /// </summary>
       /// <param name="orInfo">订单信息实体</param>
       /// <returns>true 成功 false 失败</returns>
       public Boolean GenerOrder(OrderInfo orInfo)
       {
           lock (obj)
           {
               orInfo.OrderID = 1232;
               orInfo.OrderStateID = 0;
               orInfo.PayMentStatusID = 0;
      
               return orInfoDal.AddOrderInfo(orInfo) > 0;
           }
       }
       #endregion

   }
}
