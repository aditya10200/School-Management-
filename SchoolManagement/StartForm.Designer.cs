namespace SchoolManagement
{
    partial class StartForm
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
            this.startLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.registerBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startLbl
            // 
            this.startLbl.AutoSize = true;
            this.startLbl.Location = new System.Drawing.Point(207, 86);
            this.startLbl.Name = "startLbl";
            this.startLbl.Size = new System.Drawing.Size(159, 13);
            this.startLbl.TabIndex = 0;
            this.startLbl.Text = "Do you want to login or register?";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(197, 164);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(169, 39);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // registerBtn
            // 
            this.registerBtn.Location = new System.Drawing.Point(197, 225);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(169, 39);
            this.registerBtn.TabIndex = 2;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(197, 285);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(169, 39);
            this.quitBtn.TabIndex = 3;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 364);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.startLbl);
            this.Name = "StartForm";
            this.Text = "School Management System";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.StartForm_FormClosed);
            this.Load += new System.EventHandler(this.StartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}