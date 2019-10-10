namespace MegaDesk_Goodwin
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
            this.AddQuoteBtn = new System.Windows.Forms.Button();
            this.ViewQuotesBtn = new System.Windows.Forms.Button();
            this.SearchQuotes = new System.Windows.Forms.Button();
            this.ExitMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddQuoteBtn
            // 
            this.AddQuoteBtn.Location = new System.Drawing.Point(38, 112);
            this.AddQuoteBtn.Name = "AddQuoteBtn";
            this.AddQuoteBtn.Size = new System.Drawing.Size(130, 40);
            this.AddQuoteBtn.TabIndex = 0;
            this.AddQuoteBtn.Text = "Add New Quote";
            this.AddQuoteBtn.UseVisualStyleBackColor = true;
            this.AddQuoteBtn.Click += new System.EventHandler(this.AddQuote_Click);
            // 
            // ViewQuotesBtn
            // 
            this.ViewQuotesBtn.Location = new System.Drawing.Point(38, 185);
            this.ViewQuotesBtn.Name = "ViewQuotesBtn";
            this.ViewQuotesBtn.Size = new System.Drawing.Size(130, 40);
            this.ViewQuotesBtn.TabIndex = 1;
            this.ViewQuotesBtn.Text = "View Quotes";
            this.ViewQuotesBtn.UseVisualStyleBackColor = true;
            this.ViewQuotesBtn.Click += new System.EventHandler(this.ViewQuotesBtn_Click);
            // 
            // SearchQuotes
            // 
            this.SearchQuotes.Location = new System.Drawing.Point(38, 256);
            this.SearchQuotes.Name = "SearchQuotes";
            this.SearchQuotes.Size = new System.Drawing.Size(130, 40);
            this.SearchQuotes.TabIndex = 2;
            this.SearchQuotes.Text = "Search Quotes";
            this.SearchQuotes.UseVisualStyleBackColor = true;
            this.SearchQuotes.Click += new System.EventHandler(this.SearchQuotes_Click);
            // 
            // ExitMainBtn
            // 
            this.ExitMainBtn.Location = new System.Drawing.Point(38, 327);
            this.ExitMainBtn.Name = "ExitMainBtn";
            this.ExitMainBtn.Size = new System.Drawing.Size(130, 40);
            this.ExitMainBtn.TabIndex = 3;
            this.ExitMainBtn.Text = "Exit";
            this.ExitMainBtn.UseVisualStyleBackColor = true;
            this.ExitMainBtn.Click += new System.EventHandler(this.ExitMainBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitMainBtn);
            this.Controls.Add(this.SearchQuotes);
            this.Controls.Add(this.ViewQuotesBtn);
            this.Controls.Add(this.AddQuoteBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddQuoteBtn;
        private System.Windows.Forms.Button ViewQuotesBtn;
        private System.Windows.Forms.Button SearchQuotes;
        private System.Windows.Forms.Button ExitMainBtn;
    }
}

