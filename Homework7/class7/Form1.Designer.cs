namespace class7
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Color = new System.Windows.Forms.Button();
            this.AL_B = new System.Windows.Forms.TextBox();
            this.AR_B = new System.Windows.Forms.TextBox();
            this.PL_B = new System.Windows.Forms.TextBox();
            this.PR_B = new System.Windows.Forms.TextBox();
            this.Leng_B = new System.Windows.Forms.TextBox();
            this.Depth_B = new System.Windows.Forms.TextBox();
            this.AngleLeft = new System.Windows.Forms.Label();
            this.AngleRight = new System.Windows.Forms.Label();
            this.PerLeft = new System.Windows.Forms.Label();
            this.PerRight = new System.Windows.Forms.Label();
            this.Leng = new System.Windows.Forms.Label();
            this.Depth = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Draw = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.ErrorBox = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 560);
            this.panel1.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.splitter1.Location = new System.Drawing.Point(627, 0);
            this.splitter1.Margin = new System.Windows.Forms.Padding(0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(8, 560);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.ErrorBox);
            this.panel2.Controls.Add(this.Color);
            this.panel2.Controls.Add(this.AL_B);
            this.panel2.Controls.Add(this.AR_B);
            this.panel2.Controls.Add(this.PL_B);
            this.panel2.Controls.Add(this.PR_B);
            this.panel2.Controls.Add(this.Leng_B);
            this.panel2.Controls.Add(this.Depth_B);
            this.panel2.Controls.Add(this.AngleLeft);
            this.panel2.Controls.Add(this.AngleRight);
            this.panel2.Controls.Add(this.PerLeft);
            this.panel2.Controls.Add(this.PerRight);
            this.panel2.Controls.Add(this.Leng);
            this.panel2.Controls.Add(this.Depth);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(635, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(244, 560);
            this.panel2.TabIndex = 2;
            // 
            // Color
            // 
            this.Color.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Color.Location = new System.Drawing.Point(22, 382);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(203, 35);
            this.Color.TabIndex = 12;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // AL_B
            // 
            this.AL_B.Location = new System.Drawing.Point(138, 312);
            this.AL_B.Name = "AL_B";
            this.AL_B.Size = new System.Drawing.Size(87, 21);
            this.AL_B.TabIndex = 11;
            this.AL_B.TextChanged += new System.EventHandler(this.AL_B_TextChanged);
            // 
            // AR_B
            // 
            this.AR_B.Location = new System.Drawing.Point(138, 268);
            this.AR_B.Name = "AR_B";
            this.AR_B.Size = new System.Drawing.Size(87, 21);
            this.AR_B.TabIndex = 10;
            this.AR_B.TextChanged += new System.EventHandler(this.AR_B_TextChanged);
            // 
            // PL_B
            // 
            this.PL_B.Location = new System.Drawing.Point(138, 224);
            this.PL_B.Name = "PL_B";
            this.PL_B.Size = new System.Drawing.Size(87, 21);
            this.PL_B.TabIndex = 9;
            this.PL_B.TextChanged += new System.EventHandler(this.PL_B_TextChanged);
            // 
            // PR_B
            // 
            this.PR_B.Location = new System.Drawing.Point(138, 180);
            this.PR_B.Name = "PR_B";
            this.PR_B.Size = new System.Drawing.Size(87, 21);
            this.PR_B.TabIndex = 8;
            this.PR_B.TextChanged += new System.EventHandler(this.PR_B_TextChanged);
            // 
            // Leng_B
            // 
            this.Leng_B.Location = new System.Drawing.Point(138, 136);
            this.Leng_B.Name = "Leng_B";
            this.Leng_B.Size = new System.Drawing.Size(87, 21);
            this.Leng_B.TabIndex = 7;
            this.Leng_B.TextChanged += new System.EventHandler(this.Leng_B_TextChanged);
            // 
            // Depth_B
            // 
            this.Depth_B.Location = new System.Drawing.Point(138, 92);
            this.Depth_B.Name = "Depth_B";
            this.Depth_B.Size = new System.Drawing.Size(87, 21);
            this.Depth_B.TabIndex = 6;
            this.Depth_B.TextChanged += new System.EventHandler(this.Depth_B_TextChanged);
            // 
            // AngleLeft
            // 
            this.AngleLeft.AutoSize = true;
            this.AngleLeft.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngleLeft.Location = new System.Drawing.Point(18, 314);
            this.AngleLeft.Name = "AngleLeft";
            this.AngleLeft.Size = new System.Drawing.Size(99, 19);
            this.AngleLeft.TabIndex = 5;
            this.AngleLeft.Text = "Angle Left";
            // 
            // AngleRight
            // 
            this.AngleRight.AutoSize = true;
            this.AngleRight.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AngleRight.Location = new System.Drawing.Point(18, 270);
            this.AngleRight.Name = "AngleRight";
            this.AngleRight.Size = new System.Drawing.Size(111, 19);
            this.AngleRight.TabIndex = 4;
            this.AngleRight.Text = "Angle Right";
            // 
            // PerLeft
            // 
            this.PerLeft.AutoSize = true;
            this.PerLeft.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerLeft.Location = new System.Drawing.Point(18, 226);
            this.PerLeft.Name = "PerLeft";
            this.PerLeft.Size = new System.Drawing.Size(80, 19);
            this.PerLeft.TabIndex = 3;
            this.PerLeft.Text = "Per Left";
            // 
            // PerRight
            // 
            this.PerRight.AutoSize = true;
            this.PerRight.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PerRight.Location = new System.Drawing.Point(18, 182);
            this.PerRight.Name = "PerRight";
            this.PerRight.Size = new System.Drawing.Size(92, 19);
            this.PerRight.TabIndex = 2;
            this.PerRight.Text = "Per Right";
            // 
            // Leng
            // 
            this.Leng.AutoSize = true;
            this.Leng.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Leng.Location = new System.Drawing.Point(18, 138);
            this.Leng.Name = "Leng";
            this.Leng.Size = new System.Drawing.Size(70, 19);
            this.Leng.TabIndex = 1;
            this.Leng.Text = "length";
            // 
            // Depth
            // 
            this.Depth.AutoSize = true;
            this.Depth.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depth.Location = new System.Drawing.Point(18, 94);
            this.Depth.Name = "Depth";
            this.Depth.Size = new System.Drawing.Size(60, 19);
            this.Depth.TabIndex = 0;
            this.Depth.Text = "depth";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter2.Location = new System.Drawing.Point(635, 0);
            this.splitter2.Margin = new System.Windows.Forms.Padding(0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(244, 3);
            this.splitter2.TabIndex = 3;
            this.splitter2.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.Draw);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(635, 445);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(244, 115);
            this.panel3.TabIndex = 4;
            // 
            // Draw
            // 
            this.Draw.BackColor = System.Drawing.SystemColors.Info;
            this.Draw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Draw.Font = new System.Drawing.Font("Stencil", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Draw.Location = new System.Drawing.Point(0, 0);
            this.Draw.Margin = new System.Windows.Forms.Padding(0);
            this.Draw.Name = "Draw";
            this.Draw.Size = new System.Drawing.Size(240, 111);
            this.Draw.TabIndex = 0;
            this.Draw.Text = "Draw";
            this.Draw.UseVisualStyleBackColor = false;
            this.Draw.Click += new System.EventHandler(this.Draw_Click);
            // 
            // ErrorBox
            // 
            this.ErrorBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ErrorBox.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorBox.Location = new System.Drawing.Point(0, 0);
            this.ErrorBox.MaximumSize = new System.Drawing.Size(240, 80);
            this.ErrorBox.MinimumSize = new System.Drawing.Size(240, 80);
            this.ErrorBox.Name = "ErrorBox";
            this.ErrorBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorBox.Size = new System.Drawing.Size(240, 80);
            this.ErrorBox.TabIndex = 13;
            this.ErrorBox.Text = "Error Information :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 560);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Draw;
        private System.Windows.Forms.Label PerRight;
        private System.Windows.Forms.Label Leng;
        private System.Windows.Forms.Label Depth;
        private System.Windows.Forms.Label AngleLeft;
        private System.Windows.Forms.Label AngleRight;
        private System.Windows.Forms.Label PerLeft;
        private System.Windows.Forms.TextBox AL_B;
        private System.Windows.Forms.TextBox AR_B;
        private System.Windows.Forms.TextBox PL_B;
        private System.Windows.Forms.TextBox PR_B;
        private System.Windows.Forms.TextBox Leng_B;
        private System.Windows.Forms.TextBox Depth_B;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox ErrorBox;
    }
}

