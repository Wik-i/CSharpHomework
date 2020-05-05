using System;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderServices
{

    public class Program
    {
        static void Main()
        {
            //Test for database *************************************************************************************************    2020/05/01  19:00
            /*OrderService TestService = new OrderService();

            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));

            TestService.AddToList(order_1);
            using (var context = new OrderContext())
            {
                var Order = order_1;
                context.Orders.Add(Order);
                context.SaveChanges();

            }*/
        }
    }


    [Serializable]
    public class Order
    {

        [Key]
        public int OrderNumber { get; set; }
        [Required]
        public string OrderOwner { get; set; }
        public bool OrderFinished { get; set; }
        public DateTime OrderTime { get; set; }
        public double SumOfMoney
        {
            get
            {
                double sum = 0;
                foreach (OrderItem item in ItemList) { sum += item.ItemPrice * item.ItemQuantity; }
                return sum;
            }
        }

        //private List<OrderItem> ItemList;
        [Required]
        public List<OrderItem> ItemList { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            Order objAsOrder = obj as Order;
            if (objAsOrder == null) { return false; }

            return this.OrderNumber == objAsOrder.GetHashCode();
        }
        public override int GetHashCode()
        {
            return OrderNumber;
        }
        public override string ToString()
        {
            return "订单编号：" + OrderNumber + "订单所有者" + OrderOwner + "订单时间：" + OrderTime;
        }
        public Order()
        {
            ItemList = new List<OrderItem>();
        }
        public Order(int number, string owner, DateTime time, List<OrderItem> itList)
        {
            ItemList = new List<OrderItem>();
            this.OrderNumber = number;
            this.OrderOwner = owner;
            this.OrderTime = time;
            if (itList == null) return;
            foreach (OrderItem item in itList)
            {
                ItemList.Add(item);
            }
        }
        public bool AddItem(OrderItem newItem)
        {
            OrderItem existed = ItemList.Find(x => newItem.GetHashCode() == x.GetHashCode());
            //           if (existed != null) { throw new Exception("添加项目已存在 项目编号："+existed.GetHashCode().ToString()); }
            if (existed != null) { return false; }
            ItemList.Add(newItem);
            using (var context = new OrderContext())
            {
                var item = new OrderItem(newItem.ItemNumber,newItem.ItemPrice,newItem.ItemQuantity,newItem.ItemKind,newItem.ItemProducer);
                //context.Items.Add(Item);
                //context.SaveChanges();
                var order = context.Orders.FirstOrDefault(o => o.OrderNumber == this.OrderNumber);
                if (order != null)
                {
                    order.ItemList.Add(item);
                    context.Entry(order).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            return true;
        }
        public bool AddItemInitial(OrderItem newItem)
        {
            OrderItem existed = ItemList.Find(x => newItem.GetHashCode() == x.GetHashCode());
            //           if (existed != null) { throw new Exception("添加项目已存在 项目编号："+existed.GetHashCode().ToString()); }
            if (existed != null) { return false; }
            ItemList.Add(newItem);
            return true;
        }
        public void deleteItem(int itemNumber)
        {
            OrderItem delete = ItemList.Find(x => x.ItemNumber == itemNumber);
            //if(delete==null) throw new Exception("删除Item不存在 项目编号："+delete.GetHashCode().ToString());
            if (delete == null) return;
            ItemList.Remove(delete);
            using (var context = new OrderContext())
            {
                var item = context.Items.FirstOrDefault(i => i.ItemNumber == itemNumber);
                if (item != null)
                {
                    context.Items.Remove(item);
                    context.SaveChanges();
                }
            }

        }
        public void PrintItemList()
        {
            Console.WriteLine("number    kind      price    number     producer");
            foreach (OrderItem item in ItemList)
            {
                Console.WriteLine(string.Format("{0,-6}{1,6}{2,6}{3,10}{4,20}", item.ItemNumber, item.ItemKind, item.ItemPrice, item.ItemQuantity, item.ItemProducer));
            }
        }

    }

    [Serializable]
    public class OrderItem
    {
        [Key]
        public int ItemNumber { get; set; }
        [Required]
        public double ItemPrice { get; set; }
        [Required]
        public int ItemQuantity { get; set; }
        [Required]
        public string ItemKind { get; set; }
        public string ItemProducer { get; set; }

        public int OrderID { get; set; }
        [ForeignKey("OrderID")]
        public Order Order { get; set; }


        public override string ToString()
        {
            return "商品种类：" + ItemKind + "商品价格：" + ItemPrice + "商品数量：" + ItemQuantity + "商品产商：" + ItemProducer;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            OrderItem objAsOrder = obj as OrderItem;
            if (objAsOrder == null) { return false; }
            return this.ItemNumber == obj.GetHashCode();
        }
        public override int GetHashCode()
        {
            return this.ItemNumber;
        }
        public OrderItem() { }
        public OrderItem(int number, double price, int quantity, string kind, string manufacturer)
        {
            this.ItemNumber = number;
            this.ItemPrice = price;
            this.ItemQuantity = quantity;
            this.ItemKind = kind;
            this.ItemProducer = manufacturer;
        }
    }

    [Serializable]
    public class OrderService
    {
       // public int OrderServiceID { get; set; }

        public List<Order> OrderList { get; set; }
        public OrderService()
        {
            this.OrderList = new List<Order>();
        }
        public void AddToList(Order newOrder)
        {
            Order existed = OrderList.Find(x => x.GetHashCode() == newOrder.GetHashCode());
            if (existed != null) { return; }
            OrderList.Add(newOrder);
            using (var context = new OrderContext())
            {
                //if (context == null) return;
                var order = newOrder;
                context.Orders.Add(order);
                context.SaveChanges();
            }
        }
        public void AddToListInitial(Order newOrder)
        {
            Order existed = OrderList.Find(x => x.GetHashCode() == newOrder.GetHashCode());
            if (existed != null) { return; }
            OrderList.Add(newOrder);
        }

        public bool OrderFinished(int orderNumber)
        {
            if (OrderList.Exists(x => x.OrderNumber == orderNumber))
            {
                Order order = OrderList.Find(x => x.OrderNumber == orderNumber);
                order.OrderFinished = true;
                return true;
            }
            using (var context = new OrderContext())
            {
                var order = context.Orders.FirstOrDefault(o => o.OrderNumber == orderNumber);
                if (order != null)
                {
                    order.OrderFinished = true;
                    context.SaveChanges();
                }
            }
            return false;
        }
        public bool DeleteOrder(int orderNumber)
        {
            if (OrderList.Exists(x => x.OrderNumber == orderNumber))
            {
                Order order = OrderList.Find(x => x.OrderNumber == orderNumber);
                OrderList.Remove(order);
                using (var context = new OrderContext())
                {
                    var order_1 = context.Orders.Include("ItemList").FirstOrDefault(o => o.OrderNumber == orderNumber);
                    if (order_1 != null)
                    {
                        context.Orders.Remove(order_1);
                        context.SaveChanges();
                    }
                }
                return true;
            }
            else
            {
                throw new Exception("要删除的Order不存在 Order编号：" + orderNumber);
            }

        }

        public void PrintOrderList()
        {
            Console.WriteLine("   number      time        owner    finished");
            foreach (Order o in OrderList)
            {
                Console.WriteLine(string.Format("{0,-6}{1,20}{2,6}{3,13}", o.OrderNumber, o.OrderTime, o.OrderOwner, o.OrderFinished));
            }
        }

        public IEnumerable<Order> FindOrder(string key, string type)
        {
            IEnumerable<Order> result = OrderList;
            switch (type)
            {
                case "owner":
                    result = from o in result
                             where o.OrderOwner == key
                             orderby o.SumOfMoney
                             select o;
                    break;
                case "number":
                    int number;
                    int.TryParse(key, out number);
                    result = from o in result
                             where o.OrderNumber == number
                             orderby o.SumOfMoney
                             select o;
                    break;
                case "time":
                    DateTime time;
                    DateTime.TryParse(key, out time);
                    result = from o in result
                             where o.OrderTime == time
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
                xmlSerializer.Serialize(fout, OrderList);
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
            foreach (Order o in tempList)
            {
                this.AddToList(o);
            }


        }

    }
}
