using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blowing.XiaoFengBanJia.Model.Order
{
   public  class OrderInfo
   {
       #region - feild -
       private int _ID;
       private Int64 _orderID;
       private int _orderBusinessID;
       private decimal _totalMoney;
       private Int64 _memberID;
       private int _orderStateID;
       private int _payMentStatusID;
       private DateTime _orderDate;
       private DateTime _updateDate;
       private string _avg1;
       private string _avg2;
       #endregion

       #region - property -
       /// <summary>
       /// 主键
       /// </summary>
       public int ID { set { _ID = value; } get { return _ID; } }
       /// <summary>
       /// 订单ID
       /// </summary>
       public Int64 OrderID { set { _orderID = value; } get { return _orderID; } }
       /// <summary>
       /// 关联业务ID
       /// </summary>
       public int OrderBuinessID { set { _orderBusinessID = value; } get { return _orderBusinessID; } }
       /// <summary>
       /// 订单总金额
       /// </summary>
       public decimal TotalMoney { set { _totalMoney = value; } get { return _totalMoney; } }
       /// <summary>
       /// 用户ID
       /// </summary>
       public Int64 MemberID { set { _memberID = value; } get { return _memberID; } }

       /// <summary>
       /// 订单状态
       /// </summary>
       public int OrderStateID { set { _orderStateID = value; } get { return _orderStateID; } }
       /// <summary>
       /// 支付状态
       /// </summary>
       public int PayMentStatusID { set { _payMentStatusID = value; } get { return _payMentStatusID; } }
       /// <summary>
       /// 订单生成时间
       /// </summary>
       public DateTime OrderDate { set { _orderDate = value; } get { return _orderDate; } }

       /// <summary>
       /// 更新时间
       /// </summary>
       public DateTime UpdateDate { set { _updateDate = value; } get { return _updateDate; } }
       /// <summary>
       /// 扩展字段2
       /// </summary>
       public string Avg1{ set { _avg1 = value; } get { return _avg1; } }

       /// <summary>
       /// 扩展字段2
       /// </summary>
       public string Avg2 { set { _avg2 = value; } get { return _avg2; } }

       #endregion

   }
}
