using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OrderServices;

namespace class8
{
    public partial class FormEdit : Form
    {
        public Order CurrentOrder { get; set; }
        public List<OrderItem> DeletedItems { get; set; }
        public List<OrderItem> AddedItems { get; set; }
        public FormEdit()
        {
            InitializeComponent();
            DeletedItems = new List<OrderItem>();
            AddedItems = new List<OrderItem>();
            //timeLabelContent.DataBindings.Add("Text", CurrentOrder, "OrderTime");
            //timeLabelContent.Text = CurrentOrder.OrderTime.ToString();
            //ownerLabelContent.DataBindings.Add("Text", CurrentOrder, "OrderOwner");
            //numText.DataBindings.Add("Text", CurrentOrder, "OrderNum");
            //timeLabelContent.Text = DateTime.Now.ToString();
        }

        public FormEdit(Order order, bool editMode = false) : this()
        {
            //TODO 如果想实现不点保存只关窗口后订单不变化，需要把order深克隆给CurrentOrder
            //CurrentOrder = order;
            CurrentOrder = new Order(order.OrderNumber, order.OrderOwner, order.OrderTime, order.ItemList);
            //DataBindings.Add("timeLabelContent", CurrentOrder, "orderTime");
            timeLabelContent.Text = order.OrderTime.ToString();
            ownerLabelContent.DataBindings.Add("Text", CurrentOrder, "OrderOwner");
            numText.DataBindings.Add("Text", CurrentOrder, "OrderNumber");

            orderBindingSource.DataSource = CurrentOrder;
            numText.Enabled = !editMode;
        }



        public void EditItem()
        {
            OrderItem orderItem = itemListBindingSource.Current as OrderItem;
            if(orderItem == null)
            {
                MessageBox.Show("请选择一个订单修改！");
                return;
            }
            //new form 
            FormEditItem form3 = new FormEditItem(orderItem);
            if(form3.ShowDialog() == DialogResult.OK)
            {
                CurrentOrder.deleteItem(orderItem.ItemNumber);
                CurrentOrder.AddItem(form3.CurrentItem);
                // QueryAll();
                orderBindingSource.ResetBindings(true);
            }

        }

        private void button3_Click(object sender, EventArgs e)//delete item
        {
            OrderItem orderItem = itemListBindingSource.Current as OrderItem;
            if(orderItem == null)
            {
                MessageBox.Show("请选择一个清单进行删除 ");
                return;
            }
            
            OrderItem orderItem1= new OrderItem(orderItem.ItemNumber, orderItem.ItemPrice, orderItem.ItemQuantity, orderItem.ItemKind, orderItem.ItemProducer);
            DeletedItems.Add(orderItem1);
            CurrentOrder.deleteItem(orderItem.ItemNumber);
            itemListBindingSource.ResetBindings(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            EditItem();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void button1_Click(object sender, EventArgs e)//add item
        {
            OrderItem orderItem = new OrderItem(0, 0, 0, "", "");
            FormEditItem form3 = new FormEditItem(orderItem);
            if (form3.ShowDialog() == DialogResult.OK)
            {
                CurrentOrder.AddItem(form3.CurrentItem);
                if (form3.CurrentItem != null)
                {
                    AddedItems.Add(form3.CurrentItem);
                }

                // QueryAll();
                orderBindingSource.DataSource = CurrentOrder;
                orderBindingSource.ResetBindings(false);
            }

        }
    }
}
