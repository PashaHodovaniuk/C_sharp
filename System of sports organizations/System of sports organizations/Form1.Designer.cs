namespace System_of_sports_organizations
{
    partial class F_Authorization
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
            this.label1 = new System.Windows.Forms.Label();
            this.cB_login = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tB_password = new System.Windows.Forms.TextBox();
            this.btn_SignIn = new System.Windows.Forms.Button();
            this.btn_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // cB_login
            // 
            this.cB_login.FormattingEnabled = true;
            this.cB_login.Items.AddRange(new object[] {
            "Пользователь",
            "Администратор"});
            this.cB_login.Location = new System.Drawing.Point(49, 40);
            this.cB_login.Name = "cB_login";
            this.cB_login.Size = new System.Drawing.Size(180, 21);
            this.cB_login.TabIndex = 1;
            this.cB_login.Text = "Пользователь";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // tB_password
            // 
            this.tB_password.Location = new System.Drawing.Point(49, 87);
            this.tB_password.Name = "tB_password";
            this.tB_password.Size = new System.Drawing.Size(180, 20);
            this.tB_password.TabIndex = 3;
            this.tB_password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tB_password_KeyPress);
            // 
            // btn_SignIn
            // 
            this.btn_SignIn.Location = new System.Drawing.Point(35, 113);
            this.btn_SignIn.Name = "btn_SignIn";
            this.btn_SignIn.Size = new System.Drawing.Size(105, 35);
            this.btn_SignIn.TabIndex = 4;
            this.btn_SignIn.Text = "Войти";
            this.btn_SignIn.UseVisualStyleBackColor = true;
            this.btn_SignIn.Click += new System.EventHandler(this.btn_SignIn_Click);
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(154, 113);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(105, 35);
            this.btn_Close.TabIndex = 5;
            this.btn_Close.Text = "Закрыть";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // F_Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 154);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.btn_SignIn);
            this.Controls.Add(this.tB_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cB_login);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "F_Authorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F_Authorization_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cB_login;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tB_password;
        private System.Windows.Forms.Button btn_SignIn;
        private System.Windows.Forms.Button btn_Close;
    }
}

