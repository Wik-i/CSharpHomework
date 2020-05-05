namespace class8
{
    partial class FormEditItem
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
            this.itemBox = new System.Windows.Forms.GroupBox();
            this.save = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.facLabelContent = new System.Windows.Forms.TextBox();
            this.kindLabelContent = new System.Windows.Forms.TextBox();
            this.quantityLabelContent = new System.Windows.Forms.TextBox();
            this.priceLabelContent = new System.Windows.Forms.TextBox();
            this.facLabel = new System.Windows.Forms.Label();
            this.kindLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.numLabel = new System.Windows.Forms.Label();
            this.numLabelContent = new System.Windows.Forms.TextBox();
            this.itemBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // itemBox
            // 
            this.itemBox.Controls.Add(this.save);
            this.itemBox.Controls.Add(this.tableLayoutPanel1);
            this.itemBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.itemBox.Location = new System.Drawing.Point(0, 0);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(336, 364);
            this.itemBox.TabIndex = 0;
            this.itemBox.TabStop = false;
            this.itemBox.Text = "商品详情";
            // 
            // save
            // 
            this.save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.save.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.save.Location = new System.Drawing.Point(82, 299);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(172, 53);
            this.save.TabIndex = 1;
            this.save.Text = "确认修改";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.90855F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.09145F));
            this.tableLayoutPanel1.Controls.Add(this.facLabelContent, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.kindLabelContent, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.quantityLabelContent, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.priceLabelContent, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.facLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.kindLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.quantityLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.priceLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.numLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numLabelContent, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 17);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.13274F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.86726F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // facLabelContent
            // 
            this.facLabelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.facLabelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.facLabelContent.Location = new System.Drawing.Point(98, 222);
            this.facLabelContent.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.facLabelContent.Name = "facLabelContent";
            this.facLabelContent.Size = new System.Drawing.Size(229, 26);
            this.facLabelContent.TabIndex = 13;
            // 
            // kindLabelContent
            // 
            this.kindLabelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kindLabelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kindLabelContent.Location = new System.Drawing.Point(98, 168);
            this.kindLabelContent.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.kindLabelContent.Name = "kindLabelContent";
            this.kindLabelContent.Size = new System.Drawing.Size(229, 26);
            this.kindLabelContent.TabIndex = 12;
            // 
            // quantityLabelContent
            // 
            this.quantityLabelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quantityLabelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quantityLabelContent.Location = new System.Drawing.Point(98, 113);
            this.quantityLabelContent.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.quantityLabelContent.Name = "quantityLabelContent";
            this.quantityLabelContent.Size = new System.Drawing.Size(229, 26);
            this.quantityLabelContent.TabIndex = 11;
            // 
            // priceLabelContent
            // 
            this.priceLabelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.priceLabelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLabelContent.Location = new System.Drawing.Point(98, 58);
            this.priceLabelContent.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.priceLabelContent.Name = "priceLabelContent";
            this.priceLabelContent.Size = new System.Drawing.Size(229, 26);
            this.priceLabelContent.TabIndex = 10;
            // 
            // facLabel
            // 
            this.facLabel.AutoSize = true;
            this.facLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.facLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.facLabel.Location = new System.Drawing.Point(20, 225);
            this.facLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.facLabel.Name = "facLabel";
            this.facLabel.Size = new System.Drawing.Size(72, 29);
            this.facLabel.TabIndex = 8;
            this.facLabel.Text = "商品产商";
            // 
            // kindLabel
            // 
            this.kindLabel.AutoSize = true;
            this.kindLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.kindLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.kindLabel.Location = new System.Drawing.Point(20, 171);
            this.kindLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.kindLabel.Name = "kindLabel";
            this.kindLabel.Size = new System.Drawing.Size(72, 39);
            this.kindLabel.TabIndex = 6;
            this.kindLabel.Text = "具体商品";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.quantityLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.quantityLabel.Location = new System.Drawing.Point(20, 116);
            this.quantityLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(72, 40);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "商品数量";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.priceLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.priceLabel.Location = new System.Drawing.Point(20, 61);
            this.priceLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(72, 40);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "商品价格";
            // 
            // numLabel
            // 
            this.numLabel.AutoSize = true;
            this.numLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.numLabel.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLabel.Location = new System.Drawing.Point(20, 15);
            this.numLabel.Margin = new System.Windows.Forms.Padding(3, 15, 3, 0);
            this.numLabel.Name = "numLabel";
            this.numLabel.Size = new System.Drawing.Size(72, 31);
            this.numLabel.TabIndex = 0;
            this.numLabel.Text = "商品编号";
            // 
            // numLabelContent
            // 
            this.numLabelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numLabelContent.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numLabelContent.Location = new System.Drawing.Point(98, 12);
            this.numLabelContent.Margin = new System.Windows.Forms.Padding(3, 12, 3, 3);
            this.numLabelContent.Name = "numLabelContent";
            this.numLabelContent.Size = new System.Drawing.Size(229, 26);
            this.numLabelContent.TabIndex = 9;
            // 
            // FormEditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 364);
            this.Controls.Add(this.itemBox);
            this.Name = "FormEditItem";
            this.Text = "FormEditItem";
            this.itemBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox itemBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Label facLabel;
        private System.Windows.Forms.Label kindLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label numLabel;
        private System.Windows.Forms.TextBox facLabelContent;
        private System.Windows.Forms.TextBox kindLabelContent;
        private System.Windows.Forms.TextBox quantityLabelContent;
        private System.Windows.Forms.TextBox priceLabelContent;
        private System.Windows.Forms.TextBox numLabelContent;
    }
}