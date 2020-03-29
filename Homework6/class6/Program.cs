using System;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace class5
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService myOrderService = new OrderService();
            List<OrderItem> myItems = new List<OrderItem>();
          
            myItems.Add(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            myItems.Add(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));
         

            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            try
            {
                order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
                order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));
                order_1.AddItem(new OrderItem(112, 99.00, 10, "new ak-47", "NoBattleCompany"));//添加错误异常测试
                //order_1.deleteItem(113);  //  删除错误 异常测试
            }catch(Exception ex)
            {
                Console.WriteLine("发生错误！！ 错误信息：" + ex.Message.ToString());
            }

            Order order_2 = new Order(112, "wiki", DateTime.Now, myItems);
            Console.WriteLine("myOrder itemList:");
            order_1.PrintItemList();
            Console.Write("\n");

            List<OrderItem> yourItems = new List<OrderItem>();
            yourItems.Add(new OrderItem(211,168.00, 100, "tank", "BattleCompany"));
            yourItems.Add(new OrderItem(212,99.00, 10, "plane", "BattleCompany"));
            Order order_3 = new Order(211, "mary", DateTime.Now, yourItems);
            //order_3.PrintItemList();

            try
            {
                myOrderService.AddToList(order_1);
                myOrderService.AddToList(order_2);
                myOrderService.AddToList(order_3);
                myOrderService.AddToList(order_1);//添加异常 
            }
            catch (Exception ex)
            {
                Console.WriteLine("发生错误！！错误信息：" + ex.Message.ToString());
            }
            Console.WriteLine("myOrderService Order List:");
            myOrderService.PrintOrderList();
            Console.Write("\n");


            //LINQ test
            Console.WriteLine("LINQ test: \n"+"find order which owner is wiki and print order number(orderby the sum of money):");
            var query = myOrderService.FindOrder("wiki", "owner");
            foreach (object o in query)
            {
                Console.WriteLine(o.GetHashCode());
            }
            Console.Write("\n");
            Console.WriteLine("LINQ test: \n" + "find order which nuber is 111 and print(orderby the sum of money):");
            var query_number = myOrderService.FindOrder("111", "number");
            foreach (object o in query_number)
            {
                Console.WriteLine(o.GetHashCode());
            }
            Console.Write("\n");




            //sort test
            Console.WriteLine("sort test ordered by money:");
            myOrderService.OrderList.Sort((o1, o2) => (int)o1.SumOfMoney - (int)o2.SumOfMoney);
            myOrderService.PrintOrderList();

            //export and import test
            myOrderService.ExportToXML("test.xml");
            OrderService testService = new OrderService();
            testService.ImportXML("test.xml");
            testService.PrintOrderList();


            Console.ReadLine();
            Console.ReadLine();
        }
    }


    [Serializable]
    public class Order
    {
        private int orderNumber;
        public int OrderNumber { get => orderNumber; set => orderNumber = value; }
        private string orderOwner;
        public string OrderOwner { get => orderOwner; set => orderOwner = value; }
        private bool orderFinished;
        public bool OrderFinished { get => orderFinished; set => orderFinished = value; }
        private DateTime orderTime;
        public DateTime OrderTime { get => orderTime; set => orderTime = value; }
        public double SumOfMoney { get {
                double sum=0;
                foreach (OrderItem item in itemList) { sum += item.ItemPrice * item.ItemQuantity; }
                return sum; } }

        public List<OrderItem> itemList;


        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Order objAsOrder = obj as Order;
            if (objAsOrder == null) { return false; }

            return this.orderNumber==objAsOrder.GetHashCode();
        }
        public override int GetHashCode()
        {
            return orderNumber;
        }
        public override string ToString()
        {
            return "订单编号："+orderNumber+"订单所有者"+OrderOwner+"订单时间："+orderTime;
        }
        public Order()
        {
            itemList = new List<OrderItem>();
        }
        public Order(int number,string owner,DateTime time,List<OrderItem> itList)
        {
            itemList = new List<OrderItem>();
            this.orderNumber = number;
            this.orderOwner = owner;
            this.orderTime = time;
            if (itList == null) return;
            foreach(OrderItem item in itList){
                itemList.Add(item);
            }
        }
        public bool AddItem(OrderItem newItem)
        {
            OrderItem existed = itemList.Find(x => newItem.GetHashCode() == x.GetHashCode());
            if (existed != null) { throw new Exception("添加项目已存在 项目编号："+existed.GetHashCode().ToString()); }
            itemList.Add(newItem);
            return true;
        }
        public void deleteItem(int itemNumber)
        {
            OrderItem delete = itemList.Find(x => x.itemNumber == itemNumber);
            if(delete!=null) throw new Exception("删除Item不存在 项目编号："+delete.GetHashCode().ToString());
            itemList.Remove(delete);
        }
        public void PrintItemList()
        {
            Console.WriteLine("number    kind      price    number     producer");
            foreach(OrderItem item in itemList)
            {
                Console.WriteLine(string.Format("{0,-6}{1,6}{2,6}{3,10}{4,20}",item.itemNumber, item.ItemKind, item.ItemPrice, item.ItemQuantity, item.ItemProducer));
            }
        }
        
    }

    [Serializable]
    public class OrderItem
    {
        public int itemNumber { get; set; }
        private double itemPrice;
        public double ItemPrice { get => itemPrice; set => itemPrice = value; }
        private int itemQuantity;
        public int ItemQuantity { get => itemQuantity; set => itemQuantity = value; }
        private string itemKind;
        public string ItemKind { get => itemKind; set => itemKind = value; }
        private string itemProducer;
        public string ItemProducer { get => itemProducer; set => itemProducer = value; }


        public override string ToString()
        {
            return "商品种类："+itemKind+"商品价格："+itemPrice+"商品数量："+itemQuantity+"商品产商："+itemProducer;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            OrderItem objAsOrder = obj as OrderItem;
            if (objAsOrder == null) { return false; }
            return this.itemNumber==obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return this.itemNumber;
        }
        public OrderItem() { }
        public OrderItem(int number,double price,int quantity,string kind,string manufacturer)
        {
            this.itemNumber = number;
            this.itemPrice = price;
            this.itemQuantity = quantity;
            this.itemKind = kind;
            this.itemProducer = manufacturer;
        }


    }

    [Serializable]
    public class OrderService
    {
        private List<Order> orderList;
        public List<Order> OrderList { get => orderList; }
        public OrderService() {
            this.orderList = new List<Order>();
        }
        public void AddToList(Order newOrder)
        {
            Order existed = OrderList.Find(x => x.GetHashCode() == newOrder.GetHashCode());
            if (existed!=null) { throw new Exception("添加失败 Order已存在 Order编号： " + newOrder.GetHashCode().ToString()); }
            orderList.Add(newOrder);
        }

        public bool OrderFinished(int orderNumber)
        {
            if (orderList.Exists(x => x.OrderNumber == orderNumber))
            {
                Order order = orderList.Find(x => x.OrderNumber == orderNumber);
                order.OrderFinished = true;
                return true;
            }
            return false;
        }
        public bool DeleteOrder(int orderNumber)
        {
            if (orderList.Exists(x => x.OrderNumber == orderNumber))
            {
                Order order = orderList.Find(x => x.OrderNumber == orderNumber);
                orderList.Remove(order);
                return true;
            }
            else {
                throw new Exception("要删除的Order不存在 Order编号：" + orderNumber);
            }
        }

        public void PrintOrderList()
        {
            Console.WriteLine("   number      time        owner    finished");
            foreach(Order o in OrderList)
            {
                Console.WriteLine(string.Format("{0,-6}{1,20}{2,6}{3,13}", o.OrderNumber, o.OrderTime, o.OrderOwner, o.OrderFinished));
            }
        }

        public IEnumerable<Order> FindOrder(string key,string type)
        {
            IEnumerable<Order> result = orderList;
            switch (type)
            {
                case "owner":
                     result = from o in result
                                where o.OrderOwner == key
                                orderby o.SumOfMoney
                                select o;
                    break;
                case "number":
                    result = from o in result 
                             where o.OrderNumber == int.Parse(key)
                             orderby o.SumOfMoney
                             select o;
                    break;
                case "time":
                    result = from o in result
                             where o.OrderTime == DateTime.Parse(key)
                             orderby o.SumOfMoney
                             select o;
                    break;

                default:
                    throw new Exception("非法查询字段" + type);
                    
            }
            return result;
        }

        public void ExportToXML(string fileName)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fout = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                xmlSerializer.Serialize(fout, orderList);
                fout.Close();
            }
        }

        public void ImportXML(string fileName)
        {
            List<Order> tempList = new List<Order>();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Order>));
            using (FileStream fin = new FileStream(fileName, FileMode.Open))
            {
                tempList = (List<Order>)xmlSerializer.Deserialize(fin);
                fin.Close();
            }
            foreach(Order o in tempList)
            {
                this.AddToList(o);
            }
            

        }

    }

}
