

using Blowing.XiaoFengBanJia.Common;
using Blowing.XiaoFengBanJia.Model.Order;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blowing.XiaoFengBanJia.Dal.order
{
  public  class OrderInfoDal
  {

      #region - method -

      /// <summary>
      /// 添加订单信息
      /// </summary>
      /// <param name="orInfo">订单信息实体</param>
      /// <returns>-1 失败 1成功</returns>
      public int AddOrderInfo(OrderInfo orInfo)
      {
          int resultInt = -1;

          #region - sql qy-
          string insertOrInfoQy = @"INSERT INTO  `order`.`orderinfo`(
                                     `OrderID`,
                                     `OrderBusinessID`,
                                     `TotalMoney`,
                                     `MeberID`,
                                     `OrderStateID`,
                                     `PaymentStatusID`,
                                     `OrderDate`,
                                     `OrderUpdateDate`,
                                     `avg1`,
                                     `avg2`)
                                    VALUES (
                                            @OrderID,
                                            @OrderBusinessID,
                                            @TotalMoney,
                                            @MeberID,
                                            @OrderStateID,
                                            @PaymentStatusID,
                                            @OrderDate,
                                            @OrderUpdateDate,
                                            @avg1,
                                            @avg2);";
          #endregion

          #region  - paras -
          MySqlParameter[] paras = 
           {
               new MySqlParameter("@OrderID",orInfo.OrderID),
               new MySqlParameter("@OrderBusinessID",orInfo.OrderID),
               new MySqlParameter("@TotalMoney",orInfo.TotalMoney),
               new MySqlParameter("@MeberID",orInfo.MemberID),
               new MySqlParameter("@OrderStateID",orInfo.OrderStateID),
               new MySqlParameter("@PaymentStatusID",orInfo.PayMentStatusID),
               new MySqlParameter("@OrderDate",DateTime.Now),
               new MySqlParameter("@OrderUpdateDate",DateTime.Now),
               new MySqlParameter("@avg1",string.Empty),
               new MySqlParameter("@avg2",string.Empty),

           };
          #endregion

          #region - excute -
          try
          {
              resultInt = Convert.ToInt32(DbHelperMySql.ExecuteNonQuery(DbHelperMySql.connectionStringManager, System.Data.CommandType.Text, insertOrInfoQy, paras));
          }
          catch (Exception ex)
          {
              //记录生成订单错误信息

              throw;
          }
          #endregion

          return resultInt;
      }
      #endregion
  }
}
