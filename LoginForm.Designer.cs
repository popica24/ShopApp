namespace ShopApp
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.UsernameBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.SignUpBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(88, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foo Store";
            // 
            // UsernameBox
            // 
            this.UsernameBox.Location = new System.Drawing.Point(88, 70);
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.Size = new System.Drawing.Size(151, 23);
            this.UsernameBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.Location = new System.Drawing.Point(88, 99);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(151, 23);
            this.PasswordBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Password";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(122, 131);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(75, 23);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Login";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // SignUpBox
            // 
            this.SignUpBox.Location = new System.Drawing.Point(122, 178);
            this.SignUpBox.Name = "SignUpBox";
            this.SignUpBox.Size = new System.Drawing.Size(75, 23);
            this.SignUpBox.TabIndex = 6;
            this.SignUpBox.Text = "Sign Up";
            this.SignUpBox.UseVisualStyleBackColor = true;
            this.SignUpBox.Click += new System.EventHandler(this.SignUpBox_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 243);
            this.Controls.Add(this.SignUpBox);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PasswordBox);
            this.Controls.Add(this.UsernameBox);
            this.Controls.Add(this.label1);
            this.Name = "LoginForm";
            this.Text = "Authenticate";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Label label2;
        private Label label3;
        private Button LoginButton;
        private Button SignUpBox;
    }
}