namespace TicketBookingApp
{
    partial class ConcertGoerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConcertGoerForm));
            button1 = new Button();
            label1 = new Label();
            btnBack = new Button();
            label2 = new Label();
            btnRegister = new Button();
            btnLogin = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(567, 367);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 3;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(567, 321);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(190, 39);
            label2.Name = "label2";
            label2.Size = new Size(452, 65);
            label2.TabIndex = 4;
            label2.Text = "Concert Goer Lobby";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(212, 189);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(100, 33);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(212, 265);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(100, 33);
            btnLogin.TabIndex = 6;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // ConcertGoerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogin);
            Controls.Add(btnRegister);
            Controls.Add(label2);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "ConcertGoerForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private Button btnBack;
        private Label label2;
        private Button btnRegister;
        private Button btnLogin;
    }
}