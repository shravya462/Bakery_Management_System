namespace WindowsApplication1
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderBillToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingBillToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderToolStripMenuItem,
            this.bookingToolStripMenuItem,
            this.orderBillToolStripMenuItem,
            this.purchaseDetailsToolStripMenuItem,
            this.salesDetailsToolStripMenuItem,
            this.inventoryToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(626, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // bookingToolStripMenuItem
            // 
            this.bookingToolStripMenuItem.Name = "bookingToolStripMenuItem";
            this.bookingToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.bookingToolStripMenuItem.Text = "Booking";
            // 
            // orderBillToolStripMenuItem
            // 
            this.orderBillToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.orderBillToolStripMenuItem1,
            this.bookingBillToolStripMenuItem});
            this.orderBillToolStripMenuItem.Name = "orderBillToolStripMenuItem";
            this.orderBillToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.orderBillToolStripMenuItem.Text = " Bills";
            // 
            // purchaseDetailsToolStripMenuItem
            // 
            this.purchaseDetailsToolStripMenuItem.Name = "purchaseDetailsToolStripMenuItem";
            this.purchaseDetailsToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.purchaseDetailsToolStripMenuItem.Text = "Purchase Details";
            // 
            // orderBillToolStripMenuItem1
            // 
            this.orderBillToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.orderBillToolStripMenuItem1.Name = "orderBillToolStripMenuItem1";
            this.orderBillToolStripMenuItem1.Size = new System.Drawing.Size(158, 24);
            this.orderBillToolStripMenuItem1.Text = "Order Bill";
            // 
            // bookingBillToolStripMenuItem
            // 
            this.bookingBillToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.bookingBillToolStripMenuItem.Name = "bookingBillToolStripMenuItem";
            this.bookingBillToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.bookingBillToolStripMenuItem.Text = "Booking Bill";
            // 
            // salesDetailsToolStripMenuItem
            // 
            this.salesDetailsToolStripMenuItem.Name = "salesDetailsToolStripMenuItem";
            this.salesDetailsToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.salesDetailsToolStripMenuItem.Text = "Sales Details";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 415);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form7";
            this.Text = "Main Page";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderBillToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bookingBillToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purchaseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}