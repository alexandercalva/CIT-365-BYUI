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
            this.SuspendLayout();
            // 
            // backMenuAdd
            // 
            this.backMenuAdd.AutoSize = true;
            this.backMenuAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuAdd.Location = new System.Drawing.Point(450, 368);
            this.backMenuAdd.Name = "backMenuAdd";
            this.backMenuAdd.Padding = new System.Windows.Forms.Padding(5);
            this.backMenuAdd.Size = new System.Drawing.Size(75, 40);
            this.backMenuAdd.TabIndex = 1;
            this.backMenuAdd.Text = "Menu";
            this.backMenuAdd.UseVisualStyleBackColor = true;
            this.backMenuAdd.Click += new System.EventHandler(this.backMenuAdd_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.backMenuAdd);
            this.Name = "AddQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMenuAdd;
    }
}