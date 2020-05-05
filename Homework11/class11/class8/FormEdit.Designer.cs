namespace class8
{
    partial class FormEdit
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ownerLabelContent = new System.Windows.Forms.TextBox();
            this.numLabel = new System.Windows.Forms.Label();
            this.ownerLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timeLabelContent = new System.Windows.Forms.Label();
            this.numText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQuantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemKindDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemProducerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 128);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "订单基本信息";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.16258F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.83742F));
            this.tableLayoutPanel1.Controls.Add(this.ownerLabelContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.numLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ownerLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.timeLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.timeLabelContent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.numText, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.15385F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.84615F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(559, 107);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ownerLabelContent
            // 
            this.ownerLabelContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.ownerLabelContent.Location = new System.Drawing.Point(132, 35);
            this.ownerLabelContent.Name = "ownerLabelContent";
            this.ownerLabelContent.Size = new System.Drawing.Size(300, 21);
            this.ownerLabelContent.TabIndex = 6;
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.numLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLabel.Location = new System.Drawing.Point(54, 7);
            this.numLabel.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(72, 25);
            this.numLabel.TabIndex = 0;
            this.numLabel.Text = "订单编号";
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ownerLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ownerLabel.Location = new System.Drawing.Point(86, 39);
            this.ownerLabel.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(40, 30);
            this.ownerLabel.TabIndex = 1;
            this.ownerLabel.Text = "客户";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(54, 76);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(72, 31);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "订单时间";
            // 
            // timeLabelContent
            // 
            this.timeLabelContent.AutoSize = true;
            this.timeLabelContent.Dock = System.Windows.Forms.DockStyle.Left;
            this.timeLabelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabelContent.Location = new System.Drawing.Point(139, 76);
            this.timeLabelContent.Margin = new System.Windows.Forms.Padding(10, 7, 3, 0);
            this.timeLabelContent.Name = "timeLabelContent";
            this.timeLabelContent.Size = new System.Drawing.Size(80, 31);
            this.timeLabelContent.TabIndex = 3;
            this.timeLabelContent.Text = "OrderTime";
            // 
            // numText
            // 
            this.numText.Dock = System.Windows.Forms.DockStyle.Left;
            this.numText.Location = new System.Drawing.Point(132, 3);
            this.numText.Name = "numText";
            this.numText.Size = new System.Drawing.Size(300, 21);
            this.numText.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(0, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 291);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "订单详情";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.itemPriceDataGridViewTextBoxColumn,
            this.itemQuantityDataGridViewTextBoxColumn,
            this.itemKindDataGridViewTextBoxColumn,
            this.itemProducerDataGridViewTextBoxColumn,
            this.orderIDDataGridViewTextBoxColumn,
            this.orderDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.itemListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 17);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(559, 271);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ItemNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "ItemNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
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
            // orderIDDataGridViewTextBoxColumn
            // 
            this.orderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.HeaderText = "OrderID";
            this.orderIDDataGridViewTextBoxColumn.Name = "orderIDDataGridViewTextBoxColumn";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            this.orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            this.orderDataGridViewTextBoxColumn.HeaderText = "Order";
            this.orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // itemListBindingSource
            // 
            this.itemListBindingSource.DataMember = "ItemList";
            this.itemListBindingSource.DataSource = this.orderBindingSource;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(OrderServices.Order);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 419);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 70);
            this.panel1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(443, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "确认修改";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(220, 17);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(94, 35);
            this.button3.TabIndex = 2;
            this.button3.Text = "删除商品";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(120, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "修改商品";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加商品";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 489);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.Label ownerLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label timeLabelContent;
        private System.Windows.Forms.TextBox numText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource itemListBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ownerLabelContent;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQuantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemKindDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemProducerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
    }
}