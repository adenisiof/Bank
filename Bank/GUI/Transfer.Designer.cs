namespace Bank.GUI
{
    partial class Transfer
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
            this.Value_txt = new System.Windows.Forms.TextBox();
            this.Agency_txb = new System.Windows.Forms.TextBox();
            this.Count_txb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.lbl_msn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Value_txt
            // 
            this.Value_txt.Location = new System.Drawing.Point(217, 20);
            this.Value_txt.Name = "Value_txt";
            this.Value_txt.Size = new System.Drawing.Size(100, 20);
            this.Value_txt.TabIndex = 0;
            // 
            // Agency_txb
            // 
            this.Agency_txb.Location = new System.Drawing.Point(217, 65);
            this.Agency_txb.Name = "Agency_txb";
            this.Agency_txb.Size = new System.Drawing.Size(100, 20);
            this.Agency_txb.TabIndex = 1;
            // 
            // Count_txb
            // 
            this.Count_txb.Location = new System.Drawing.Point(217, 103);
            this.Count_txb.Name = "Count_txb";
            this.Count_txb.Size = new System.Drawing.Size(100, 20);
            this.Count_txb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Agencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Conta com digito";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(276, 160);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Confirmar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(165, 160);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancelar";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // lbl_msn
            // 
            this.lbl_msn.AutoSize = true;
            this.lbl_msn.Location = new System.Drawing.Point(336, 215);
            this.lbl_msn.Name = "lbl_msn";
            this.lbl_msn.Size = new System.Drawing.Size(0, 13);
            this.lbl_msn.TabIndex = 9;
            // 
            // Transfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.lbl_msn);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Count_txb);
            this.Controls.Add(this.Agency_txb);
            this.Controls.Add(this.Value_txt);
            this.Name = "Transfer";
            this.Text = "Tranfer";
            this.Load += new System.EventHandler(this.Tranfer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Value_txt;
        private System.Windows.Forms.TextBox Agency_txb;
        private System.Windows.Forms.TextBox Count_txb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label lbl_msn;
    }
}