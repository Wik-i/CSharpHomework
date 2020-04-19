



namespace class8
{
    partial class SearchBox
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.head = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.menu = new System.Windows.Forms.FlowLayoutPanel();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.importButton = new System.Windows.Forms.Button();
            this.exportButton = new System.Windows.Forms.Button();
            this.behavior = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.findType = new System.Windows.Forms.ComboBox();
            this.searchKey = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.itemListView = new System.Windows.Forms.DataGridView();
            this.itemNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemProducerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderListView = new System.Windows.Forms.DataGridView();
            this.orderNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderOwnerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderFinishedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.orderTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sumOfMoneyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.head.SuspendLayout();
            this.menu.SuspendLayout();
            this.behavior.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemListView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListView)).BeginInit();
            this.SuspendLayout();
            // 
            // head
            // 
            this.head.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.head.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.head.Controls.Add(this.header);
            this.head.Dock = System.Windows.Forms.DockStyle.Top;
            this.head.Location = new System.Drawing.Point(0, 0);
            this.head.Name = "head";
            this.head.Size = new System.Drawing.Size(1091, 62);
            this.head.TabIndex = 0;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Font = new System.Drawing.Font("隶书", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(314, 48);
            this.header.TabIndex = 0;
            this.header.Text = "订单管理程序";
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.menu.Controls.Add(this.addButton);
            this.menu.Controls.Add(this.deleteButton);
            this.menu.Controls.Add(this.importButton);
            this.menu.Controls.Add(this.exportButton);
            this.menu.Dock = System.Windows.Forms.DockStyle.Top;
            this.menu.Location = new System.Drawing.Point(0, 62);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1091, 38);
            this.menu.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(3, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(122, 29);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "添加订单";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(131, 3);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 29);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "删除订单";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // importButton
            // 
            this.importButton.Location = new System.Drawing.Point(259, 3);
            this.importButton.Name = "importButton";
            this.importButton.Size = new System.Drawing.Size(122, 29);
            this.importButton.TabIndex = 4;
            this.importButton.Text = "订单导入";
            this.importButton.UseVisualStyleBackColor = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(387, 3);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(122, 29);
            this.exportButton.TabIndex = 3;
            this.exportButton.Text = "订单导出";
            this.exportButton.UseVisualStyleBackColor = true;
            this.exportButton.Click += new System.EventHandler(this.exportButton_Click);
            // 
            // behavior
            // 
            this.behavior.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.behavior.Controls.Add(this.label1);
            this.behavior.Controls.Add(this.findType);
            this.behavior.Controls.Add(this.searchKey);
            this.behavior.Controls.Add(this.search);
            this.behavior.Dock = System.Windows.Forms.DockStyle.Top;
            this.behavior.Location = new System.Drawing.Point(0, 100);
            this.behavior.Name = "behavior";
            this.behavior.Size = new System.Drawing.Size(1091, 38);
            this.behavior.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 5, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "查询类型";
            // 
            // findType
            // 
            this.findType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.findType.FormattingEnabled = true;
            this.findType.Items.AddRange(new object[] {
            "所有订单：",
            "订单号：",
            "订单所有者：",
            "订单时间："});
            this.findType.Location = new System.Drawing.Point(88, 3);
            this.findType.Name = "findType";
            this.findType.Size = new System.Drawing.Size(122, 20);
            this.findType.TabIndex = 3;
            // 
            // searchKey
            // 
            this.searchKey.Location = new System.Drawing.Point(216, 3);
            this.searchKey.Name = "searchKey";
            this.searchKey.Size = new System.Drawing.Size(345, 21);
            this.searchKey.TabIndex = 1;
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(567, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(119, 21);
            this.search.TabIndex = 2;
            this.search.Text = "查询";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.itemListView);
            this.panel1.Controls.Add(this.orderListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1091, 332);
            this.panel1.TabIndex = 3;
            // 
            // itemListView
            // 
            this.itemListView.AutoGenerateColumns = false;
            this.itemListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemNumberDataGridViewTextBoxColumn,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemKindDataGridViewTextBoxColumn,
            this.itemProducerDataGridViewTextBoxColumn});
            this.itemListView.DataSource = this.itemListBindingSource;
            this.itemListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemListView.Location = new System.Drawing.Point(545, 0);
            this.itemListView.Name = "itemListView";
            this.itemListView.RowTemplate.Height = 23;
            this.itemListView.Size = new System.Drawing.Size(546, 332);
            this.itemListView.TabIndex = 1;
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            this.itemNumberDataGridViewTextBoxColumn.DataPropertyName = "itemNumber";
            this.itemNumberDataGridViewTextBoxColumn.HeaderText = "itemNumber";
            this.itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            // 
            // itemPriceDataGridViewTextBoxColumn
            // 
            this.itemPriceDataGridViewTextBoxColumn.DataPropertyName = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.HeaderText = "ItemPrice";
            this.itemPriceDataGridViewTextBoxColumn.Name = "itemPriceDataGridViewTextBoxColumn";
            // 
            // itemQuantityDataGridViewTextBoxColumn
            // 
            this.itemQuantityDataGridViewTextBoxColumn.DataPropertyName = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.HeaderText = "ItemQuantity";
            this.itemQuantityDataGridViewTextBoxColumn.Name = "itemQuantityDataGridViewTextBoxColumn";
            // 
            // itemKindDataGridViewTextBoxColumn
            // 
            this.itemKindDataGridViewTextBoxColumn.DataPropertyName = "ItemKind";
            this.itemKindDataGridViewTextBoxColumn.HeaderText = "ItemKind";
            this.itemKindDataGridViewTextBoxColumn.Name = "itemKindDataGridViewTextBoxColumn";
            // 
            // itemProducerDataGridViewTextBoxColumn
            // 
            this.itemProducerDataGridViewTextBoxColumn.DataPropertyName = "ItemProducer";
            this.itemProducerDataGridViewTextBoxColumn.HeaderText = "ItemProducer";
            this.itemProducerDataGridViewTextBoxColumn.Name = "itemProducerDataGridViewTextBoxColumn";
            // 
            // itemListBindingSource
            // 
            this.itemListBindingSource.DataMember = "ItemList";
            this.itemListBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(class5.Order);
            // 
            // orderListView
            // 
            this.orderListView.AutoGenerateColumns = false;
            this.orderListView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.orderListView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumberDataGridViewTextBoxColumn,
            this.orderOwnerDataGridViewTextBoxColumn,
            this.orderFinishedDataGridViewCheckBoxColumn,
            this.orderTimeDataGridViewTextBoxColumn,
            this.sumOfMoneyDataGridViewTextBoxColumn});
            this.orderListView.DataSource = this.orderBindingSource;
            this.orderListView.Dock = System.Windows.Forms.DockStyle.Left;
            this.orderListView.Location = new System.Drawing.Point(0, 0);
            this.orderListView.Name = "orderListView";
            this.orderListView.ReadOnly = true;
            this.orderListView.RowTemplate.Height = 23;
            this.orderListView.RowTemplate.ReadOnly = true;
            this.orderListView.Size = new System.Drawing.Size(545, 332);
            this.orderListView.StandardTab = true;
            this.orderListView.TabIndex = 5;
            this.orderListView.DoubleClick += new System.EventHandler(this.orderListView_DoubleClick);
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            this.orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.HeaderText = "OrderNumber";
            this.orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            this.orderNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderOwnerDataGridViewTextBoxColumn
            // 
            this.orderOwnerDataGridViewTextBoxColumn.DataPropertyName = "OrderOwner";
            this.orderOwnerDataGridViewTextBoxColumn.HeaderText = "OrderOwner";
            this.orderOwnerDataGridViewTextBoxColumn.Name = "orderOwnerDataGridViewTextBoxColumn";
            this.orderOwnerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // orderFinishedDataGridViewCheckBoxColumn
            // 
            this.orderFinishedDataGridViewCheckBoxColumn.DataPropertyName = "OrderFinished";
            this.orderFinishedDataGridViewCheckBoxColumn.HeaderText = "OrderFinished";
            this.orderFinishedDataGridViewCheckBoxColumn.Name = "orderFinishedDataGridViewCheckBoxColumn";
            this.orderFinishedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // orderTimeDataGridViewTextBoxColumn
            // 
            this.orderTimeDataGridViewTextBoxColumn.DataPropertyName = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.HeaderText = "OrderTime";
            this.orderTimeDataGridViewTextBoxColumn.Name = "orderTimeDataGridViewTextBoxColumn";
            this.orderTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sumOfMoneyDataGridViewTextBoxColumn
            // 
            this.sumOfMoneyDataGridViewTextBoxColumn.DataPropertyName = "SumOfMoney";
            this.sumOfMoneyDataGridViewTextBoxColumn.HeaderText = "SumOfMoney";
            this.sumOfMoneyDataGridViewTextBoxColumn.Name = "sumOfMoneyDataGridViewTextBoxColumn";
            this.sumOfMoneyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 470);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.behavior);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.head);
            this.Name = "SearchBox";
            this.Text = "订单管理程序";
            this.head.ResumeLayout(false);
            this.head.PerformLayout();
            this.menu.ResumeLayout(false);
            this.behavior.ResumeLayout(false);
            this.behavior.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemListView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderListView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel head;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.FlowLayoutPanel menu;
        private System.Windows.Forms.FlowLayoutPanel behavior;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.TextBox searchKey;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox findType;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button importButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView itemListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemProducerDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemListBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderListView;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderOwnerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn orderFinishedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sumOfMoneyDataGridViewTextBoxColumn;
    }
}

