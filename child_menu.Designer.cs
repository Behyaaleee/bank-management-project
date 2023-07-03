namespace bank_acc
{
    partial class child_menu
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
            this.deposit = new System.Windows.Forms.Button();
            this.inquiry = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(876, 325);
            this.deposit.Margin = new System.Windows.Forms.Padding(4);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(151, 90);
            this.deposit.TabIndex = 7;
            this.deposit.Text = "deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // inquiry
            // 
            this.inquiry.Location = new System.Drawing.Point(876, 183);
            this.inquiry.Margin = new System.Windows.Forms.Padding(4);
            this.inquiry.Name = "inquiry";
            this.inquiry.Size = new System.Drawing.Size(151, 97);
            this.inquiry.TabIndex = 6;
            this.inquiry.Text = "inquiry";
            this.inquiry.UseVisualStyleBackColor = true;
            this.inquiry.Click += new System.EventHandler(this.inquiry_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(876, 48);
            this.withdraw.Margin = new System.Windows.Forms.Padding(4);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(152, 87);
            this.withdraw.TabIndex = 5;
            this.withdraw.Text = "withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // child_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.inquiry);
            this.Controls.Add(this.withdraw);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "child_menu";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.child_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button inquiry;
        private System.Windows.Forms.Button withdraw;
    }
}