using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using class5;

namespace class8
{
    
    public partial class FormEditItem : Form
    {
        public OrderItem CurrentItem { get; set; }
        public FormEditItem()
        {
            InitializeComponent();

        }

        public FormEditItem(OrderItem item,bool editMode = false) : this()
        {
            CurrentItem = new OrderItem(item.itemNumber, item.ItemPrice, item.ItemQuantity, item.ItemKind, item.ItemProducer);
            numLabelContent.DataBindings.Add("Text", CurrentItem, "ItemNumber");
            priceLabelContent.DataBindings.Add("Text", CurrentItem, "ItemPrice");
            quantityLabelContent.DataBindings.Add("Text", CurrentItem, "ItemQuantity");
            kindLabelContent.DataBindings.Add("Text", CurrentItem, "ItemKind");
            facLabelContent.DataBindings.Add("Text", CurrentItem, "ItemProducer");


        }

        private void save_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }




    }
}
