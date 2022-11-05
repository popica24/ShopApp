namespace ShopApp
{
    partial class ShopForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TheList = new System.Windows.Forms.Label();
            this.Price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TheList);
            this.groupBox1.Controls.Add(this.Price);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(643, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(145, 555);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cart";
            // 
            // TheList
            // 
            this.TheList.AutoSize = true;
            this.TheList.Location = new System.Drawing.Point(28, 35);
            this.TheList.Name = "TheList";
            this.TheList.Size = new System.Drawing.Size(66, 15);
            this.TheList.TabIndex = 2;
            this.TheList.Text = "Empty Cart";
            // 
            // Price
            // 
            this.Price.AutoSize = true;
            this.Price.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Price.Location = new System.Drawing.Point(75, 530);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(19, 21);
            this.Price.TabIndex = 1;
            this.Price.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(6, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total :";
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(643, 579);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(145, 23);
            this.OrderBtn.TabIndex = 2;
            this.OrderBtn.Text = "Order";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Window;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 47);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(625, 555);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // ShopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 614);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShopForm";
            this.Text = "ShopForm";
            this.Load += new System.EventHandler(this.ShopForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private Label Price;
        private Button OrderBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label TheList;
    }
}