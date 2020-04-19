using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using class5;

namespace class8
{
    public partial class SearchBox : Form
    {
        OrderService myOrderService;
        //BindingSource orderLists = new BindingSource();
        public SearchBox()
        {
            InitializeComponent();
            myOrderService = new OrderService();
            List<OrderItem> myItems = new List<OrderItem>();

            myItems.Add(new OrderItem(111, 168.00, 100, "grenade", "NoBattleCompany"));
            myItems.Add(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));
            Order order_1 = new Order(111, "wiki", DateTime.Now, null);
            order_1.AddItem(new OrderItem(111, 168.00, 10, "grenade", "NoBattleCompany"));
            order_1.AddItem(new OrderItem(112, 99.00, 10, "ak-47", "NoBattleCompany"));
            List<OrderItem> yourItems = new List<OrderItem>();
            yourItems.Add(new OrderItem(211, 168.00, 100, "tank", "BattleCompany"));
            yourItems.Add(new OrderItem(212, 99.00, 10, "plane", "BattleCompany"));
            Order order_3 = new Order(211, "mary", DateTime.Now, yourItems);
            myOrderService.AddToList(order_1);
            myOrderService.AddToList(order_3);




            orderBindingSource.DataSource = myOrderService.OrderList;

            //orderbin.AutoGenerateColumns = true;

            findType.SelectedIndex = 0;//select


        }

        

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void importButton_Click(object sender, EventArgs e)
        {
            string path;
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C:\\";
            fileDialog.Filter = "XML文件|*.xml|所有文件|*.*|本文件|*.txt";
            fileDialog.RestoreDirectory = false;    //若为false，则打开对话框后为上次的目录。若为true，则为初始目录
            if (fileDialog.ShowDialog() == DialogResult.OK) 
            { 
                path  = System.IO.Path.GetFullPath(fileDialog.FileName);//将选中的文件的路径传递给TextBox “FilePath”
                myOrderService.ImportXML(path);
            }
            QueryAll();
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            string path;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML文件|*.xml|所有文件|*.*|本文件|*.txt";
            saveFileDialog.InitialDirectory = "C:\\";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                String fileName = saveFileDialog.FileName;
                myOrderService.ExportToXML(fileName);

            }


        }

  
        private void search_Click(object sender, EventArgs e)
        {
            switch (findType.SelectedIndex)
            {
                case 0://all orders
                    orderBindingSource.DataSource = myOrderService.OrderList;
                    break;
                case 1://order number search 
                    List<Order> numOrdList = new List<Order>();
                    foreach(Order order in myOrderService.FindOrder(searchKey.Text, "number")){
                        numOrdList.Add(order);
                    }
                    orderBindingSource.DataSource = numOrdList;
                    break;
                case 2:
                    List<Order> OwnerOrdList = new List<Order>();
                    foreach(Order order in myOrderService.FindOrder(searchKey.Text, "owner"))
                    {
                        OwnerOrdList.Add(order);
                    }
                    orderBindingSource.DataSource = OwnerOrdList;
                    break;
                case 3:
                    List<Order> TimeOrdList = new List<Order>();
                    foreach(Order order in myOrderService.FindOrder(searchKey.Text, "time"))
                    {
                        TimeOrdList.Add(order);
                    }
                    orderBindingSource.DataSource = TimeOrdList;
                    break;
                default:
                    break;
            }
            orderBindingSource.ResetBindings(true);
        }
        private void QueryAll()
        {
            orderBindingSource.DataSource = myOrderService.OrderList;
            orderBindingSource.ResetBindings(false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if(order == null)
            {
                MessageBox.Show("请选择一个订单进行删除！！");
                return;
            }
            myOrderService.DeleteOrder(order.OrderNumber);
            QueryAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormEdit form2 = new FormEdit(new Order());
            if(form2.ShowDialog() == DialogResult.OK)
            {
                myOrderService.AddToList(form2.CurrentOrder);
                QueryAll();
            }

        }

        private void orderListView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        private void EditOrder()
        {
            Order order = orderBindingSource.Current as Order;
            if(order == null)
            {
                MessageBox.Show("请选择一个订单进行修改！");
                return;
            }
            FormEdit form2 = new FormEdit();
            if(form2.ShowDialog() == DialogResult.OK)
            {
                myOrderService.AddToList(form2.CurrentOrder);
                QueryAll();
            }



        }

        private void orderListView_DoubleClick(object sender, EventArgs e)
        {
            Order order = orderBindingSource.Current as Order;
            if(order != null) {
                FormEdit form2 = new FormEdit(order);
                if(form2.ShowDialog() == DialogResult.OK)
                {
                    myOrderService.DeleteOrder(order.OrderNumber);
                    myOrderService.AddToList(form2.CurrentOrder);
                    QueryAll();
                }
            }
        }
    }


}
