namespace WinFormsApp3.Views
{
    partial class WelcomeForm
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
            label1 = new Label();
            btnContact = new Button();
            btnLogin = new Button();
            btnRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 40F);
            label1.Location = new Point(43, 40);
            label1.MaximumSize = new Size(1000, 1000);
            label1.Name = "label1";
            label1.Size = new Size(711, 80);
            label1.TabIndex = 0;
            label1.Text = "Welcome To Sahara";
            label1.Click += label1_Click;
            // 
            // btnContact
            // 
            btnContact.Font = new Font("Segoe UI", 22F);
            btnContact.Location = new Point(61, 198);
            btnContact.Name = "btnContact";
            btnContact.Size = new Size(221, 90);
            btnContact.TabIndex = 1;
            btnContact.Text = "Contact";
            btnContact.UseVisualStyleBackColor = true;
            btnContact.Click += button1_Click;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 22F);
            btnLogin.Location = new Point(515, 198);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(219, 90);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += button2_Click;
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 22F);
            btnRegister.Location = new Point(288, 198);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(221, 90);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += button3_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(btnContact);
            Controls.Add(label1);
            Name = "WelcomeForm";
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnContact;
        private Button btnLogin;
        private Button btnRegister;
    }
}