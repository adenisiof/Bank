using System.Drawing;
namespace BankSystem
{
    partial class MyAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyAccount));
            this.lbl_Balance = new System.Windows.Forms.Label();
            this.Transfer = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Deposit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Balance
            // 
            this.lbl_Balance.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbl_Balance.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Balance.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_Balance.Location = new System.Drawing.Point(96, 15);
            this.lbl_Balance.Name = "lbl_Balance";
            this.lbl_Balance.Size = new System.Drawing.Size(138, 31);
            this.lbl_Balance.TabIndex = 0;
            this.lbl_Balance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Transfer
            // 
            this.Transfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Transfer.Location = new System.Drawing.Point(55, 139);
            this.Transfer.Name = "Transfer";
            this.Transfer.Size = new System.Drawing.Size(130, 38);
            this.Transfer.TabIndex = 2;
            this.Transfer.Text = "Transferencia";
            this.Transfer.UseVisualStyleBackColor = true;
            this.Transfer.Click += new System.EventHandler(this.Transfer_Click);
            // 
            // Payment
            // 
            this.Payment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Payment.Location = new System.Drawing.Point(55, 200);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(130, 38);
            this.Payment.TabIndex = 3;
            this.Payment.Text = "Pagamentos";
            this.Payment.UseVisualStyleBackColor = true;
            this.Payment.Click += new System.EventHandler(this.Payment_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(240, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Saldo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.saldo_btn);
            // 
            // Deposit
            // 
            this.Deposit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Deposit.Location = new System.Drawing.Point(55, 80);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(130, 38);
            this.Deposit.TabIndex = 0;
            this.Deposit.Text = "Extrato";
            this.Deposit.UseVisualStyleBackColor = true;
            this.Deposit.Click += new System.EventHandler(this.Stratum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "R$";
            // 
            // MyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(503, 508);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.Transfer);
            this.Controls.Add(this.Deposit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_Balance);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MyAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "My Account";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Balance;
        private System.Windows.Forms.Button Transfer;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Deposit;
        private System.Windows.Forms.Label label1;
    }
}