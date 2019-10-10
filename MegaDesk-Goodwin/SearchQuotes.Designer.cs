namespace MegaDesk_Goodwin
{
    partial class SearchQuotes
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
            this.SearchToMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchToMainBtn
            // 
            this.SearchToMainBtn.Location = new System.Drawing.Point(713, 415);
            this.SearchToMainBtn.Name = "SearchToMainBtn";
            this.SearchToMainBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchToMainBtn.TabIndex = 0;
            this.SearchToMainBtn.Text = "Close";
            this.SearchToMainBtn.UseVisualStyleBackColor = true;
            this.SearchToMainBtn.Click += new System.EventHandler(this.SearchToMainBtn_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchToMainBtn);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SearchToMainBtn;
    }
}