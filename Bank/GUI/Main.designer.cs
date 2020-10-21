namespace BankSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.Pass_lbl = new System.Windows.Forms.Label();
            this.Email_lbl = new System.Windows.Forms.Label();
            this.PassLog_txb = new System.Windows.Forms.TextBox();
            this.EmLog_txb = new System.Windows.Forms.TextBox();
            this.pictureBox1_img = new System.Windows.Forms.PictureBox();
            this.login_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_img)).BeginInit();
            this.SuspendLayout();
            // 
            // Pass_lbl
            // 
            this.Pass_lbl.AutoSize = true;
            this.Pass_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Pass_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Pass_lbl.Location = new System.Drawing.Point(48, 190);
            this.Pass_lbl.Name = "Pass_lbl";
            this.Pass_lbl.Size = new System.Drawing.Size(59, 19);
            this.Pass_lbl.TabIndex = 2;
            this.Pass_lbl.Text = "Senha";
            // 
            // Email_lbl
            // 
            this.Email_lbl.AutoSize = true;
            this.Email_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Email_lbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_lbl.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Email_lbl.Location = new System.Drawing.Point(51, 142);
            this.Email_lbl.Name = "Email_lbl";
            this.Email_lbl.Size = new System.Drawing.Size(54, 19);
            this.Email_lbl.TabIndex = 3;
            this.Email_lbl.Text = "Email";
            // 
            // PassLog_txb
            // 
            this.PassLog_txb.Location = new System.Drawing.Point(130, 189);
            this.PassLog_txb.Name = "PassLog_txb";
            this.PassLog_txb.Size = new System.Drawing.Size(229, 20);
            this.PassLog_txb.TabIndex = 4;
            // 
            // EmLog_txb
            // 
            this.EmLog_txb.Location = new System.Drawing.Point(130, 141);
            this.EmLog_txb.Name = "EmLog_txb";
            this.EmLog_txb.Size = new System.Drawing.Size(229, 20);
            this.EmLog_txb.TabIndex = 5;
            // 
            // pictureBox1_img
            // 
            this.pictureBox1_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1_img.BackgroundImage")));
            this.pictureBox1_img.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1_img.Location = new System.Drawing.Point(91, 25);
            this.pictureBox1_img.Name = "pictureBox1_img";
            this.pictureBox1_img.Size = new System.Drawing.Size(289, 103);
            this.pictureBox1_img.TabIndex = 0;
            this.pictureBox1_img.TabStop = false;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.Teal;
            this.login_btn.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.Info;
            this.login_btn.Location = new System.Drawing.Point(365, 174);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(87, 35);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "Entrar";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pictureBox1_img);
            this.Controls.Add(this.EmLog_txb);
            this.Controls.Add(this.PassLog_txb);
            this.Controls.Add(this.Email_lbl);
            this.Controls.Add(this.Pass_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank System";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1_img)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Pass_lbl;
        private System.Windows.Forms.Label Email_lbl;
        private System.Windows.Forms.TextBox PassLog_txb;
        private System.Windows.Forms.TextBox EmLog_txb;
        private System.Windows.Forms.PictureBox pictureBox1_img;
        private System.Windows.Forms.Button login_btn;
    }
}

