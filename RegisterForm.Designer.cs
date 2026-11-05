namespace TicketBookingApp
{
    partial class RegisterForm
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
            txtname = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtEmail = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
            btnCreate = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // txtname
            // 
            txtname.Location = new Point(269, 150);
            txtname.Name = "txtname";
            txtname.Size = new Size(242, 23);
            txtname.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 153);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(230, 22);
            label2.Name = "label2";
            label2.Size = new Size(281, 65);
            label2.TabIndex = 2;
            label2.Text = "Registration";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(188, 214);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 3;
            label3.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(268, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(243, 23);
            txtEmail.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(188, 269);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 5;
            label4.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(268, 267);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 23);
            txtPassword.TabIndex = 6;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(556, 339);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(113, 51);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create Account";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(114, 339);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(91, 51);
            btnBack.TabIndex = 8;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBack);
            Controls.Add(btnCreate);
            Controls.Add(txtPassword);
            Controls.Add(label4);
            Controls.Add(txtEmail);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtname);
            Name = "RegisterForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtname;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtEmail;
        private Label label4;
        private TextBox txtPassword;
        private Button btnCreate;
        private Button btnBack;
    }
}