namespace MegaDesk
{
    partial class MainMenu
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
            this.newQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.AutoSize = true;
            this.newQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.Location = new System.Drawing.Point(76, 109);
            this.newQuote.MaximumSize = new System.Drawing.Size(500, 500);
            this.newQuote.Name = "newQuote";
            this.newQuote.Padding = new System.Windows.Forms.Padding(10);
            this.newQuote.Size = new System.Drawing.Size(167, 52);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "Add New Quote";
            this.newQuote.UseVisualStyleBackColor = true;
            this.newQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.AutoSize = true;
            this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.Location = new System.Drawing.Point(76, 167);
            this.viewQuotes.MaximumSize = new System.Drawing.Size(500, 500);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Padding = new System.Windows.Forms.Padding(10);
            this.viewQuotes.Size = new System.Drawing.Size(167, 52);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = true;
            // 
            // searchQuotes
            // 
            this.searchQuotes.AutoSize = true;
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.Location = new System.Drawing.Point(76, 225);
            this.searchQuotes.MaximumSize = new System.Drawing.Size(500, 500);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Padding = new System.Windows.Forms.Padding(10);
            this.searchQuotes.Size = new System.Drawing.Size(167, 52);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(76, 283);
            this.exit.MaximumSize = new System.Drawing.Size(500, 500);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(10);
            this.exit.Size = new System.Drawing.Size(167, 52);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.newQuote);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
    }
}

