using Microsoft.VisualStudio.TestTools.UnitTesting;
using class5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class5.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {
        [TestMethod()]
        public void OrderServiceTest()
        {
            OrderService myOrderService = new OrderService();
        }

        [TestMethod()]
        public void AddToListTest()
        {
            OrderService TestService = new OrderService();

            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));

            TestService.AddToList(order_1);
        }

        [TestMethod()]
        public void OrderFinishedTest()
        {

        }

        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService TestService = new OrderService();

            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));

            TestService.AddToList(order_1);
            TestService.DeleteOrder(111);
            //TestService.DeleteOrder(-111);//unexisted order number

        }

        [TestMethod()]
        public void PrintOrderListTest()
        {
            OrderService TestService = new OrderService();
            // 打印空
            TestService.PrintOrderList();

            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));

            TestService.AddToList(order_1);
            TestService.PrintOrderList();
        }

        [TestMethod()]
        public void FindOrderTest()
        {
            OrderService TestService = new OrderService();
            // 空查找
            TestService.FindOrder("111","number");

            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));

            TestService.AddToList(order_1);
            TestService.FindOrder("111", "number");
            //不存在查找
            TestService.FindOrder("222", "number");
 

        }

        [TestMethod()]
        public void ExportToXMLTest()
        {
            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));
            OrderService myService = new OrderService();
            myService.AddToList(order_1);
            myService.ExportToXML("test.xml");
        }

        [TestMethod()]
        public void ImportXMLTest()
        {
            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));
            OrderService myService = new OrderService();
            myService.AddToList(order_1);
            myService.ExportToXML("test.xml");
            //string path = @"E:\code repertory\VS repertory\C#\class6\class6Tests\bin\Debug\test.xml";

            OrderService yourService = new OrderService();
            yourService.ImportXML("test.xml");
            if (myService.Equals(yourService)) {
                throw new Exception("import fail");
            }

        }
    }
}