namespace MegaDesk
{
    partial class DisplayQuote
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
            this.backMenuDisplay = new System.Windows.Forms.Button();
            this.customerText = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.Label();
            this.depthText = new System.Windows.Forms.Label();
            this.drawersText = new System.Windows.Forms.Label();
            this.materialText = new System.Windows.Forms.Label();
            this.orderText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backMenuDisplay
            // 
            this.backMenuDisplay.AutoSize = true;
            this.backMenuDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuDisplay.Location = new System.Drawing.Point(656, 571);
            this.backMenuDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backMenuDisplay.Name = "backMenuDisplay";
            this.backMenuDisplay.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.backMenuDisplay.Size = new System.Drawing.Size(112, 62);
            this.backMenuDisplay.TabIndex = 0;
            this.backMenuDisplay.Text = "Menu";
            this.backMenuDisplay.UseVisualStyleBackColor = true;
            this.backMenuDisplay.Click += new System.EventHandler(this.backMenuDisplay_Click);
            // 
            // customerText
            // 
            this.customerText.AutoSize = true;
            this.customerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerText.Location = new System.Drawing.Point(44, 34);
            this.customerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.customerText.Name = "customerText";
            this.customerText.Size = new System.Drawing.Size(78, 20);
            this.customerText.TabIndex = 1;
            this.customerText.Text = "Customer";
            this.customerText.Click += new System.EventHandler(this.label1_Click);
            // 
            // widthText
            // 
            this.widthText.AutoSize = true;
            this.widthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthText.Location = new System.Drawing.Point(46, 97);
            this.widthText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(50, 20);
            this.widthText.TabIndex = 2;
            this.widthText.Text = "Width";
            // 
            // depthText
            // 
            this.depthText.AutoSize = true;
            this.depthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthText.Location = new System.Drawing.Point(46, 164);
            this.depthText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.depthText.Name = "depthText";
            this.depthText.Size = new System.Drawing.Size(53, 20);
            this.depthText.TabIndex = 3;
            this.depthText.Text = "Depth";
            // 
            // drawersText
            // 
            this.drawersText.AutoSize = true;
            this.drawersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersText.Location = new System.Drawing.Point(46, 236);
            this.drawersText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drawersText.Name = "drawersText";
            this.drawersText.Size = new System.Drawing.Size(68, 20);
            this.drawersText.TabIndex = 4;
            this.drawersText.Text = "Drawers";
            // 
            // materialText
            // 
            this.materialText.AutoSize = true;
            this.materialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialText.Location = new System.Drawing.Point(46, 306);
            this.materialText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialText.Name = "materialText";
            this.materialText.Size = new System.Drawing.Size(65, 20);
            this.materialText.TabIndex = 5;
            this.materialText.Text = "Material";
            // 
            // orderText
            // 
            this.orderText.AutoSize = true;
            this.orderText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderText.Location = new System.Drawing.Point(46, 387);
            this.orderText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.orderText.Name = "orderText";
            this.orderText.Size = new System.Drawing.Size(87, 20);
            this.orderText.TabIndex = 6;
            this.orderText.Text = "Order Time";
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(854, 683);
            this.Controls.Add(this.orderText);
            this.Controls.Add(this.materialText);
            this.Controls.Add(this.drawersText);
            this.Controls.Add(this.depthText);
            this.Controls.Add(this.widthText);
            this.Controls.Add(this.customerText);
            this.Controls.Add(this.backMenuDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMenuDisplay;
        public System.Windows.Forms.Label customerText;
        public System.Windows.Forms.Label widthText;
        public System.Windows.Forms.Label depthText;
        public System.Windows.Forms.Label drawersText;
        public System.Windows.Forms.Label materialText;
        public System.Windows.Forms.Label orderText;
    }
}