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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.newQuote = new System.Windows.Forms.Button();
            this.viewQuotes = new System.Windows.Forms.Button();
            this.searchQuotes = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // newQuote
            // 
            this.newQuote.AllowDrop = true;
            this.newQuote.AutoSize = true;
            this.newQuote.BackColor = System.Drawing.Color.Beige;
            this.newQuote.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newQuote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.newQuote.Location = new System.Drawing.Point(12, 69);
            this.newQuote.MaximumSize = new System.Drawing.Size(500, 500);
            this.newQuote.Name = "newQuote";
            this.newQuote.Padding = new System.Windows.Forms.Padding(10);
            this.newQuote.Size = new System.Drawing.Size(167, 52);
            this.newQuote.TabIndex = 0;
            this.newQuote.Text = "Add New Quote";
            this.newQuote.UseVisualStyleBackColor = false;
            this.newQuote.Click += new System.EventHandler(this.button1_Click);
            // 
            // viewQuotes
            // 
            this.viewQuotes.AllowDrop = true;
            this.viewQuotes.AutoSize = true;
            this.viewQuotes.BackColor = System.Drawing.Color.Beige;
            this.viewQuotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.viewQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewQuotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewQuotes.Location = new System.Drawing.Point(12, 290);
            this.viewQuotes.MaximumSize = new System.Drawing.Size(500, 500);
            this.viewQuotes.Name = "viewQuotes";
            this.viewQuotes.Padding = new System.Windows.Forms.Padding(10);
            this.viewQuotes.Size = new System.Drawing.Size(167, 52);
            this.viewQuotes.TabIndex = 1;
            this.viewQuotes.Text = "View Quotes";
            this.viewQuotes.UseVisualStyleBackColor = false;
            this.viewQuotes.Click += new System.EventHandler(this.viewQuotes_Click);
            // 
            // searchQuotes
            // 
            this.searchQuotes.AllowDrop = true;
            this.searchQuotes.AutoSize = true;
            this.searchQuotes.BackColor = System.Drawing.Color.Beige;
            this.searchQuotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchQuotes.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.searchQuotes.Location = new System.Drawing.Point(451, 69);
            this.searchQuotes.MaximumSize = new System.Drawing.Size(500, 500);
            this.searchQuotes.Name = "searchQuotes";
            this.searchQuotes.Padding = new System.Windows.Forms.Padding(10);
            this.searchQuotes.Size = new System.Drawing.Size(167, 52);
            this.searchQuotes.TabIndex = 2;
            this.searchQuotes.Text = "Search Quotes";
            this.searchQuotes.UseVisualStyleBackColor = false;
            this.searchQuotes.Click += new System.EventHandler(this.searchQuotes_Click);
            // 
            // exit
            // 
            this.exit.AllowDrop = true;
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Beige;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.exit.Location = new System.Drawing.Point(451, 290);
            this.exit.MaximumSize = new System.Drawing.Size(500, 500);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(10);
            this.exit.Size = new System.Drawing.Size(167, 52);
            this.exit.TabIndex = 3;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Date";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(630, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.searchQuotes);
            this.Controls.Add(this.viewQuotes);
            this.Controls.Add(this.newQuote);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MainMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk- Alexander Calva";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newQuote;
        private System.Windows.Forms.Button viewQuotes;
        private System.Windows.Forms.Button searchQuotes;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
    }
}

