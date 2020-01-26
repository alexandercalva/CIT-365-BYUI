namespace MegaDesk
{
    partial class AddQuote
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
            this.backMenuAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.customerBox = new System.Windows.Forms.TextBox();
            this.widthBox = new System.Windows.Forms.TextBox();
            this.depthBox = new System.Windows.Forms.TextBox();
            this.drawersBox = new System.Windows.Forms.TextBox();
            this.materialBox = new System.Windows.Forms.ComboBox();
            this.orderBox = new System.Windows.Forms.ComboBox();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backMenuAdd
            // 
            this.backMenuAdd.AutoSize = true;
            this.backMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuAdd.Location = new System.Drawing.Point(482, 392);
            this.backMenuAdd.Name = "backMenuAdd";
            this.backMenuAdd.Padding = new System.Windows.Forms.Padding(5);
            this.backMenuAdd.Size = new System.Drawing.Size(75, 40);
            this.backMenuAdd.TabIndex = 1;
            this.backMenuAdd.Text = "Menu";
            this.backMenuAdd.UseVisualStyleBackColor = true;
            this.backMenuAdd.Click += new System.EventHandler(this.backMenuAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Width";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Depth";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Drawers";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(384, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Order Time";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // customerBox
            // 
            this.customerBox.Location = new System.Drawing.Point(33, 71);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(292, 20);
            this.customerBox.TabIndex = 8;
            // 
            // widthBox
            // 
            this.widthBox.Location = new System.Drawing.Point(33, 137);
            this.widthBox.Name = "widthBox";
            this.widthBox.Size = new System.Drawing.Size(292, 20);
            this.widthBox.TabIndex = 9;
            this.widthBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.widthBox.Validated += new System.EventHandler(this.widthInput);
            // 
            // depthBox
            // 
            this.depthBox.Location = new System.Drawing.Point(33, 212);
            this.depthBox.Name = "depthBox";
            this.depthBox.Size = new System.Drawing.Size(292, 20);
            this.depthBox.TabIndex = 10;
            this.depthBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthInput);
            this.depthBox.Validating += new System.ComponentModel.CancelEventHandler(this.DepthNumber);
            // 
            // drawersBox
            // 
            this.drawersBox.Location = new System.Drawing.Point(33, 286);
            this.drawersBox.Name = "drawersBox";
            this.drawersBox.Size = new System.Drawing.Size(292, 20);
            this.drawersBox.TabIndex = 11;
            // 
            // materialBox
            // 
            this.materialBox.FormattingEnabled = true;
            this.materialBox.Location = new System.Drawing.Point(33, 358);
            this.materialBox.Name = "materialBox";
            this.materialBox.Size = new System.Drawing.Size(292, 21);
            this.materialBox.TabIndex = 12;
            // 
            // orderBox
            // 
            this.orderBox.FormattingEnabled = true;
            this.orderBox.Location = new System.Drawing.Point(388, 70);
            this.orderBox.Name = "orderBox";
            this.orderBox.Size = new System.Drawing.Size(83, 21);
            this.orderBox.TabIndex = 13;
            // 
            // addButton
            // 
            this.addButton.AutoSize = true;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(388, 392);
            this.addButton.Name = "addButton";
            this.addButton.Padding = new System.Windows.Forms.Padding(5);
            this.addButton.Size = new System.Drawing.Size(75, 40);
            this.addButton.TabIndex = 14;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.orderBox);
            this.Controls.Add(this.materialBox);
            this.Controls.Add(this.drawersBox);
            this.Controls.Add(this.depthBox);
            this.Controls.Add(this.widthBox);
            this.Controls.Add(this.customerBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backMenuAdd);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMenuAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox customerBox;
        private System.Windows.Forms.TextBox widthBox;
        private System.Windows.Forms.TextBox depthBox;
        private System.Windows.Forms.TextBox drawersBox;
        private System.Windows.Forms.ComboBox materialBox;
        private System.Windows.Forms.ComboBox orderBox;
        private System.Windows.Forms.Button addButton;
    }
}