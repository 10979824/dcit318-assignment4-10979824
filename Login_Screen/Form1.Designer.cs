namespace Login_Screen
{
    partial class Form1
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
            Login = new Button();
            textUsername = new TextBox();
            username = new Label();
            label1 = new Label();
            textPassword = new TextBox();
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(367, 277);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // textUsername
            // 
            textUsername.Location = new Point(352, 163);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(125, 27);
            textUsername.TabIndex = 1;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(352, 140);
            username.Name = "username";
            username.Size = new Size(73, 20);
            username.TabIndex = 2;
            username.Text = "username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 203);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 4;
            label1.Text = "password";
            // 
            // textPassword
            // 
            textPassword.Location = new Point(352, 226);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(125, 27);
            textPassword.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(username);
            Controls.Add(textUsername);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private TextBox textUsername;
        private Label username;
        private Label label1;
        private TextBox textPassword;
    }
}
