namespace TicketBookingApp
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            label1 = new Label();
            label2 = new Label();
            rbConcertGoer = new RadioButton();
            rbEventOrganiser = new RadioButton();
            rbAdmin = new RadioButton();
            btnContinue = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(276, 43);
            label1.Name = "label1";
            label1.Size = new Size(248, 65);
            label1.TabIndex = 0;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(316, 175);
            label2.Name = "label2";
            label2.Size = new Size(165, 32);
            label2.TabIndex = 1;
            label2.Text = "Who are you?";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rbConcertGoer
            // 
            rbConcertGoer.AutoSize = true;
            rbConcertGoer.Location = new Point(353, 242);
            rbConcertGoer.Name = "rbConcertGoer";
            rbConcertGoer.Size = new Size(95, 19);
            rbConcertGoer.TabIndex = 2;
            rbConcertGoer.TabStop = true;
            rbConcertGoer.Text = "Concert Goer";
            rbConcertGoer.UseVisualStyleBackColor = true;
            // 
            // rbEventOrganiser
            // 
            rbEventOrganiser.AutoSize = true;
            rbEventOrganiser.Location = new Point(354, 283);
            rbEventOrganiser.Name = "rbEventOrganiser";
            rbEventOrganiser.Size = new Size(108, 19);
            rbEventOrganiser.TabIndex = 3;
            rbEventOrganiser.TabStop = true;
            rbEventOrganiser.Text = "Event Organiser";
            rbEventOrganiser.UseVisualStyleBackColor = true;
            // 
            // rbAdmin
            // 
            rbAdmin.AutoSize = true;
            rbAdmin.Location = new Point(353, 324);
            rbAdmin.Name = "rbAdmin";
            rbAdmin.Size = new Size(61, 19);
            rbAdmin.TabIndex = 4;
            rbAdmin.TabStop = true;
            rbAdmin.Text = "Admin";
            rbAdmin.UseVisualStyleBackColor = true;
            // 
            // btnContinue
            // 
            btnContinue.Location = new Point(533, 363);
            btnContinue.Name = "btnContinue";
            btnContinue.Size = new Size(75, 23);
            btnContinue.TabIndex = 5;
            btnContinue.Text = "Continue";
            btnContinue.UseVisualStyleBackColor = true;
            btnContinue.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(533, 392);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 6;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click_1;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnContinue);
            Controls.Add(rbAdmin);
            Controls.Add(rbEventOrganiser);
            Controls.Add(rbConcertGoer);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rbConcertGoer;
        private RadioButton rbEventOrganiser;
        private RadioButton rbAdmin;
        private Button btnContinue;
        private Button btnExit;
    }
}
