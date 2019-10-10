namespace MegaDesk_Goodwin
{
    partial class ViewQuotes
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
            this.ViewMainBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ViewMainBtn
            // 
            this.ViewMainBtn.Location = new System.Drawing.Point(688, 415);
            this.ViewMainBtn.Name = "ViewMainBtn";
            this.ViewMainBtn.Size = new System.Drawing.Size(75, 23);
            this.ViewMainBtn.TabIndex = 0;
            this.ViewMainBtn.Text = "Close";
            this.ViewMainBtn.UseVisualStyleBackColor = true;
            this.ViewMainBtn.Click += new System.EventHandler(this.ViewMainBtn_Click);
            // 
            // ViewQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ViewMainBtn);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewQuotes";
            this.Text = "ViewQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ViewMainBtn;
    }
}