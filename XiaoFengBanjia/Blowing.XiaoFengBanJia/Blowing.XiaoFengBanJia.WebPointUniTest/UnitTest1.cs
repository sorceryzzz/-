using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Blowing.XiaoFengBanJia.WebPoint.Controllers;

namespace Blowing.XiaoFengBanJia.WebPointUniTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrderController orController = new OrderController();
            decimal totalmoney = 0;
            int orBuissnessID = -1;

           string contentStr= orController.GenerOrderPost(totalmoney, orBuissnessID).Content;

           Assert.IsTrue(contentStr == "-1");
           totalmoney = 10;
           orBuissnessID = 0;
           contentStr = orController.GenerOrderPost(totalmoney, orBuissnessID).Content;
           Assert.IsTrue(contentStr == "1");

        }
    }
}
