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
            this.SuspendLayout();
            // 
            // backMenuDisplay
            // 
            this.backMenuDisplay.AutoSize = true;
            this.backMenuDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backMenuDisplay.Location = new System.Drawing.Point(437, 371);
            this.backMenuDisplay.Name = "backMenuDisplay";
            this.backMenuDisplay.Padding = new System.Windows.Forms.Padding(5);
            this.backMenuDisplay.Size = new System.Drawing.Size(75, 40);
            this.backMenuDisplay.TabIndex = 0;
            this.backMenuDisplay.Text = "Menu";
            this.backMenuDisplay.UseVisualStyleBackColor = true;
            this.backMenuDisplay.Click += new System.EventHandler(this.backMenuDisplay_Click);
            // 
            // DisplayQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(569, 444);
            this.Controls.Add(this.backMenuDisplay);
            this.Name = "DisplayQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DisplayQuote";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMenuDisplay;
    }
}