namespace MegaDesk_Goodwin
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
            this.AddToMainBtn = new System.Windows.Forms.Button();
            this.AddQuoteSubmitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddToMainBtn
            // 
            this.AddToMainBtn.Location = new System.Drawing.Point(702, 415);
            this.AddToMainBtn.Name = "AddToMainBtn";
            this.AddToMainBtn.Size = new System.Drawing.Size(75, 23);
            this.AddToMainBtn.TabIndex = 0;
            this.AddToMainBtn.Text = "Exit";
            this.AddToMainBtn.UseVisualStyleBackColor = true;
            this.AddToMainBtn.Click += new System.EventHandler(this.AddToMainBtn_Click);
            // 
            // AddQuoteSubmitBtn
            // 
            this.AddQuoteSubmitBtn.Location = new System.Drawing.Point(294, 415);
            this.AddQuoteSubmitBtn.Name = "AddQuoteSubmitBtn";
            this.AddQuoteSubmitBtn.Size = new System.Drawing.Size(75, 23);
            this.AddQuoteSubmitBtn.TabIndex = 1;
            this.AddQuoteSubmitBtn.Text = "Submit";
            this.AddQuoteSubmitBtn.UseVisualStyleBackColor = true;
            this.AddQuoteSubmitBtn.Click += new System.EventHandler(this.AddQuoteSubmitBtn_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddQuoteSubmitBtn);
            this.Controls.Add(this.AddToMainBtn);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddToMainBtn;
        private System.Windows.Forms.Button AddQuoteSubmitBtn;
    }
}