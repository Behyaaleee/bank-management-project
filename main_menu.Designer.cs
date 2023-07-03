namespace bank_acc
{
    partial class main_menu
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
            this.tranfere = new System.Windows.Forms.Button();
            this.create_child = new System.Windows.Forms.Button();
            this.inquiry = new System.Windows.Forms.Button();
            this.deposit = new System.Windows.Forms.Button();
            this.withdraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tranfere
            // 
            this.tranfere.Location = new System.Drawing.Point(56, 27);
            this.tranfere.Margin = new System.Windows.Forms.Padding(4);
            this.tranfere.Name = "tranfere";
            this.tranfere.Size = new System.Drawing.Size(147, 87);
            this.tranfere.TabIndex = 0;
            this.tranfere.Text = "Transfer";
            this.tranfere.UseVisualStyleBackColor = true;
            this.tranfere.Click += new System.EventHandler(this.tranfere_Click);
            // 
            // create_child
            // 
            this.create_child.Location = new System.Drawing.Point(56, 162);
            this.create_child.Margin = new System.Windows.Forms.Padding(4);
            this.create_child.Name = "create_child";
            this.create_child.Size = new System.Drawing.Size(147, 98);
            this.create_child.TabIndex = 1;
            this.create_child.Text = "Create a child";
            this.create_child.UseVisualStyleBackColor = true;
            this.create_child.Click += new System.EventHandler(this.create_child_Click);
            // 
            // inquiry
            // 
            this.inquiry.Location = new System.Drawing.Point(821, 162);
            this.inquiry.Margin = new System.Windows.Forms.Padding(4);
            this.inquiry.Name = "inquiry";
            this.inquiry.Size = new System.Drawing.Size(151, 97);
            this.inquiry.TabIndex = 3;
            this.inquiry.Text = "Inquiry";
            this.inquiry.UseVisualStyleBackColor = true;
            this.inquiry.Click += new System.EventHandler(this.inquiry_Click);
            // 
            // deposit
            // 
            this.deposit.Location = new System.Drawing.Point(821, 304);
            this.deposit.Margin = new System.Windows.Forms.Padding(4);
            this.deposit.Name = "deposit";
            this.deposit.Size = new System.Drawing.Size(151, 90);
            this.deposit.TabIndex = 4;
            this.deposit.Text = "Deposit";
            this.deposit.UseVisualStyleBackColor = true;
            this.deposit.Click += new System.EventHandler(this.deposit_Click);
            // 
            // withdraw
            // 
            this.withdraw.Location = new System.Drawing.Point(821, 27);
            this.withdraw.Margin = new System.Windows.Forms.Padding(4);
            this.withdraw.Name = "withdraw";
            this.withdraw.Size = new System.Drawing.Size(152, 87);
            this.withdraw.TabIndex = 2;
            this.withdraw.Text = "Withdraw";
            this.withdraw.UseVisualStyleBackColor = true;
            this.withdraw.Click += new System.EventHandler(this.withdraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(388, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 45);
            this.label1.TabIndex = 5;
            this.label1.Text = "main menu";
            // 
            // main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deposit);
            this.Controls.Add(this.inquiry);
            this.Controls.Add(this.withdraw);
            this.Controls.Add(this.create_child);
            this.Controls.Add(this.tranfere);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "main_menu";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tranfere;
        private System.Windows.Forms.Button create_child;
        private System.Windows.Forms.Button inquiry;
        private System.Windows.Forms.Button deposit;
        private System.Windows.Forms.Button withdraw;
        private System.Windows.Forms.Label label1;
    }
}